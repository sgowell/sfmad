using System;
using System.Collections.Generic;
using FluentNHibernate.Data;
using NHibernate;
using NHibernate.Criterion;
using Web.Models;

namespace Web.Data
{
    public interface IRepository
    {
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        void Flush();
    }

    public interface IRepository<T> : IRepository
    {
        void Clear();
        void Save(T entity);
        void Delete(T entity);
        void SaveOrUpdate(T entity);
        T GetFirst();
        T Load(object ID);
        IList<T> GetAll();
        IList<T> GetAll(int pageNumber, int pageSize);
        T GetBy(string propertyName, object value);
        IList<T> FindAll(IDictionary<string, object> propertyValuePairs);
        T FindOne(IDictionary<string, object> propertyValuePairs);
        void Evict(object item);
    }

    public interface ITransectRepository : IRepository<Transect>
    {

    }

    public class TransactionRepository : RepositoryBase<Transect>, ITransectRepository, IRepository
    {
        public TransactionRepository(ISession session) : base(session)
        {
        }
    }

    public class RepositoryBase<T> : IRepository<T>
    {
        private readonly ISession session;

        public RepositoryBase(ISession session)
        {
            this.session = session;
        }

        public void BeginTransaction()
        {
            session.BeginTransaction();
        }

        public void CommitTransaction()
        {
            session.Transaction.Commit();
        }

        public void RollbackTransaction()
        {
            session.Transaction.Rollback();
        }

        public void Flush()
        {
            session.Flush();
        }

        protected IQuery getQuery(string hql)
        {
            return session.CreateQuery(hql);
        }
        protected ICriteria getCriteria()
        {           
            return session.CreateCriteria(typeof(T));            
        }

        public void Clear()
        {
            session.Clear();            
        }

        public void Evict(object item)
        {
           session.Evict(item);
        }

        public void Save(T entity)
        {
            session.SaveOrUpdate(entity);
        }

        public void Delete(T entity)
        {
            session.Delete(entity);
        }

        public void SaveOrUpdate(T entity)
        {
            session.SaveOrUpdate(entity);
        }

        public T GetFirst()
        {                        
            return getCriteria().SetMaxResults(1).UniqueResult<T>();
        }

        public T Load(object ID)
        {
            return session.Get<T>(ID);
        }

        public IList<T> GetAll()
        {
            return getCriteria().List<T>();
        }

        public IList<T> GetAll(int pageNumber, int pageSize)
        {
            var criteria = getCriteria();
            criteria.SetMaxResults(pageSize);
            criteria.SetFirstResult((pageNumber - 1) * pageSize);
            return criteria.List<T>();
        }

        public T GetBy(string propertyName, object value)
        {
            var criteria = getCriteria();
            criteria.Add(Expression.Eq(propertyName, value));
            return criteria.UniqueResult<T>();
        }

        public virtual IList<T> FindAll(IDictionary<string, object> propertyValuePairs)
        {
            Check.Require(propertyValuePairs != null && propertyValuePairs.Count > 0,
                "propertyValuePairs was null or empty; " +
                "it has to have at least one property/value pair in it");

            ICriteria criteria = getCriteria();

            foreach (string key in propertyValuePairs.Keys)
            {
                var value = propertyValuePairs[key];
                if (value != null)
                {
                    if(value is string)
                        criteria.Add(Expression.Like(key, propertyValuePairs[key] + "%"));
                    else
                        criteria.Add(Expression.Eq(key, propertyValuePairs[key]));
                }
                else
                {
                    criteria.Add(Expression.IsNull(key));
                }
            }

            return criteria.List<T>();
        }

        public virtual T FindOne(IDictionary<string, object> propertyValuePairs)
        {
            IList<T> foundList = FindAll(propertyValuePairs);

            if (foundList.Count > 1)
            {
                throw new NonUniqueResultException(foundList.Count);
            }
            else if (foundList.Count == 1)
            {
                return foundList[0];
            }

            return default(T);
        }
    }

}