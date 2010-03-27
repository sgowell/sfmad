using System;
using System.Threading;
using System.Web;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NatureConservancy;
using NatureConservatory;
using NHibernate;
using NHibernate.Cfg;
using Web.Models.Mappings;

namespace NatureConservancy
{
    public interface ISessionFactoryFactory
    {
        ISessionFactory GetSessionFactory();
        ISession GetSession();
        void EndSession();
    }

    public class SessionFactoryFactory : ISessionFactoryFactory
    {
        public Action<Configuration> OnFactoryCreation { get; set; }

        private ISessionFactory sessionFactory;

        public ISessionFactory GetSessionFactory()
        {
            if (sessionFactory != null)
                return sessionFactory;

            var config = MsSqlConfiguration
                .MsSql2005.ConnectionString(c => c.Is("ConnectionString".AppSetting()));

            config.ShowSql();

            sessionFactory = Fluently.Configure()
                .Database(config)
                .Mappings(m => m.FluentMappings.Add(typeof(TransectMapping)))
                .ExposeConfiguration(OnFactoryCreation)
                .BuildSessionFactory();

            return sessionFactory;
        }

        const string SLOT_NAME = "SessionFactoryFactory.currentSession";
        // TODO: to make this useful outside of web, support non web contexts
        private ISession currentSession
        {
            get
            {
                if (System.Web.HttpContext.Current == null)
                {
                    ISession tlsSession;
                    // make sure there is space in TLS
                    LocalDataStoreSlot DataSlot = Thread.GetNamedDataSlot(SLOT_NAME);
                    // see if there is a value in TLS
                    tlsSession = Thread.GetData(DataSlot) as ISession;
                    return tlsSession;
                }

                return HttpContext.Current.Items[SLOT_NAME] as ISession;
            }
            set
            {
                if (System.Web.HttpContext.Current == null)
                {
                    // make sure there is space in TLS
                    LocalDataStoreSlot DataSlot = Thread.GetNamedDataSlot(SLOT_NAME);
                    // see if there is a value in TLS
                    Thread.SetData(DataSlot, value);
                }
                else
                {
                    if (HttpContext.Current.Items.Contains(SLOT_NAME))
                        HttpContext.Current.Items[SLOT_NAME] = value;
                    else
                        HttpContext.Current.Items.Add(SLOT_NAME, value);
                }
            }


        }

        public ISession GetSession()
        {
            if (currentSession == null)
                currentSession = GetSessionFactory().OpenSession();

            return currentSession;
        }

        public void EndSession()
        {
            if (currentSession != null)
            {
                currentSession.Flush();
            }
        }
    }
}