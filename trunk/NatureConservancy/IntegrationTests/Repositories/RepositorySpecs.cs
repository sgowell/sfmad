using System;
using System.Collections.Generic;
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
    public class RepositorySpecs
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

        public void can_persist_transect()
        {
            new PersistenceSpecification<Transect>(GetSession())
                .CheckProperty(x => x.Number, 234)
                .CheckProperty(x => x.Latitude, 34.343)
                .CheckProperty(x => x.Longitude, 44.343)
                .CheckReference(x => x.Stand, new Stand())
                .CheckList(x => x.Surveys, new List<Survey> {new Survey()})
                .VerifyTheMappings();
        }

       

        [Test]
        public void can_persist_stand()
        {
            new PersistenceSpecification<Stand>(GetSession())
                .CheckProperty(x => x.Name, "A")
                .VerifyTheMappings();
        }

        [Test]
        public void can_persist_survey()
        {
            new PersistenceSpecification<Survey>(GetSession())
                .CheckProperty(x => x.Bearing, 234)
                .VerifyTheMappings();
        }

        [Test]
        public void can_persist_EcoRegion()
        {
            new PersistenceSpecification<EcoRegion>(GetSession())
                .CheckProperty(x => x.RegionNumber, 13)
                .CheckProperty(x => x.Name, "Northern Fen")
                .VerifyTheMappings();
        }

        //todo fix this test
        [Test]
        public void can_persist_DeerHerbivory()
        {
            new PersistenceSpecification<DeerHerbivory>(GetSession())
                .CheckReference(x => x.Species, new Species())
                .CheckProperty(x => x.Browsed, 12)
                .CheckProperty(x => x.Unbrowsed, 8)
                //.CheckProperty(x => x.Id, "SPEC1")
                .CheckProperty(x => x.Browsed, true)
                .CheckReference(x => x.Understory, new Understory())

                .VerifyTheMappings();
        }

        [Test]
        public void can_persist_Species()
        {
            new PersistenceSpecification<Species>(GetSession())
                .CheckProperty(x => x.SpeciesAcronym, "ABBABB")
                .CheckProperty(x => x.ScientificName, "SPEC1")
                .CheckProperty(x => x.CommonName, "White Pine")
                .VerifyTheMappings();
        }


        [Test]
        public void can_persist_Microtopography()
        {
            new PersistenceSpecification<Microtopography>(GetSession())
                .CheckProperty(x => x.Id, 13)
                .CheckProperty(x => x.Comments, "Micro generates few comments")
                //.CheckReference(x => x.DevelopmentIntensity, new MicrotopographyAmount())
                .CheckReference(x => x.DevelopmentIntensity, new Microtopography.MicrotopographyAmount())
                .CheckReference(x => x.Survey, new Survey())
                .VerifyTheMappings();
        }

        [Test]
        public void can_persist_Overstory()
        {
            new PersistenceSpecification<Overstory>(GetSession())

                .CheckReference(x => x.OverstoryItems, new List<OverstoryItem>())
                .CheckReference(x => x.Survey, new Survey())
                .CheckReference(x => x.Notes, string.Empty)
                .CheckReference(x => x.Snags, new List<Snag>())
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
}