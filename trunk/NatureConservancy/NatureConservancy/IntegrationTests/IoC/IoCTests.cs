using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Web.Controllers;
using Web.Services;

namespace IntegrationTests.IoC
{
    [TestFixture]
    public class IoCTests
    {
        [Test]
        public void can_resolve_controller()
        {
            Container.Resolve<SurveyController>().ShouldNotBeNull();
        }
    }
}
