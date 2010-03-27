using System;
using NHibernate;
using StructureMap;
using Web.Data;
using Web.Models;

namespace Web.Services
{
    public static class Container
    {
        public static T Resolve<T>()
        {
            return ObjectFactory.GetInstance<T>();
        }

        public static T Resolve<T>(string key)
        {
            return ObjectFactory.GetNamedInstance<T>(key);
        }

        public static object Resolve(Type type)
        {
            return ObjectFactory.GetInstance(type);
        }


        static Container() { _Initialize(); }

        private static void _Initialize()
        {
            ObjectFactory.Initialize(i =>
            {
                i.ForRequestedType<IMembershipService>()
                    .TheDefaultIsConcreteType<AccountMembershipService>();

                i.ForRequestedType<ISessionFactoryFactory>()
                    .TheDefaultIsConcreteType<SessionFactoryFactory>();
                i.ForRequestedType<ISession>()
                    .TheDefault.Is.ConstructedBy(
                        c => c.GetInstance<ISessionFactoryFactory>().GetSession()
                    );

                i.ForRequestedType<ITransectRepository>()
                    .TheDefaultIsConcreteType<TransactionRepository>();
//                i.Scan(x =>
//                {
//                    x.Assembly("Web");
//                    x.AddAllTypesOf<Web.Data.IRepository>();
//                    x.WithDefaultConventions();
//                });

           

            });

        }

    }
}
