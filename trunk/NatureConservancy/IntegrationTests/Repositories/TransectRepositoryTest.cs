﻿using System;
using FluentNHibernate.Testing;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;
using Web.Data;
using Web.Models;
using Web.Services;

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

        [Test]
        public void can_retrieve_from_repository()
        {
            var transect = TransectFixture.Create();
            var repository = Container.Resolve<ITransectRepository>();

            repository.Save(transect);
            var transectId = transect.Id;
            transect = repository.Load(transect.Id);
            transect.Id.ShouldEqual(transectId);
            
        }
    }

    public static class TransectFixture
    {
        public static Transect Create()
        {
            return new Transect();
        }
    }
}