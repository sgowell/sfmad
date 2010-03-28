using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
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
            repo.Flush();
            var allDebris = (controller.New(survey.Id) as ViewResult).ViewData.Model as IEnumerable<WoodyDebris>;            
            allDebris.Count().ShouldEqual(1);
            allDebris.First().ShouldEqual(debris);
        }
    }
}
