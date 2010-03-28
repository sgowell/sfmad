using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IntegrationTests.Repositories;
using NUnit.Framework;
using Web.Controllers;
using Web.Data;
using Web.Models;
using Web.Services;

namespace IntegrationTests.ControllerTests
{
    [TestFixture]
    public class WoodyDebrisControllerTests 
    {
        [Test]
        public void should_save_woody_debris()
        {
            var controller = Container.Resolve<WoodyDebrisController>();
            var survey = SurveyFixture.Create();
            var repo = Container.Resolve<ISurveyRepository>();
            repo.Save(survey);
            var debris = WoodyDebrisFixture.Create();
            controller.New(survey.Id, debris);
            survey = repo.Load(survey.Id);
            survey.WoodyDebris.Count().ShouldEqual(1);
            survey.WoodyDebris.First().ShouldEqual(debris);
        }
    }
}
