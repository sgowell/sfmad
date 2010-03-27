using System;
using FluentNHibernate.Testing;
using NatureConservancy;
using NatureConservatory;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;

namespace IntegrationTests.Repositories
{
    [TestFixture]
    public class TransectRepositorySpecs
    {
        protected ISession GetSession()
        {
            return new SessionFactoryFactory().GetSessionFactory().OpenSession();
        }

        [SetUp]
        public void CreateSchema()
        {

            var factory = new SessionFactoryFactory();
            factory.OnFactoryCreation = configuration =>
            {
                var exporter = new SchemaExport(configuration);
                exporter.Create(true, true);
                exporter.Execute(false, true, false, true);
                Console.WriteLine("done");
            };
            var sessionFactory = factory.GetSessionFactory();
        }

        [Test]
        public void can_persist()
        {
            new PersistenceSpecification<Transect>(GetSession())
                .CheckProperty(x => x.TransectNumber, 234)
                .CheckProperty(x=>x.TransectClass, "Pretttty")
                .CheckProperty(x=>x.Latitude, 34.343)
                .CheckProperty(x => x.Longitude, 44.343)
                .VerifyTheMappings();
        }
    }
}
