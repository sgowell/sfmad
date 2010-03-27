using System;
using FluentNHibernate.Testing;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;

namespace IntegrationTests.Repositories
{
    [TestFixture]
    public class CountyRepositorySpecs
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
            new PersistenceSpecification<County>(GetSession())
                .CheckProperty(x => x.Name, "Luzene")
                .VerifyTheMappings();
        }




    }
}
