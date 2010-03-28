using System;
using Web.Models;

namespace IntegrationTests.Repositories
{
    public static class TransectFixture
    {
        public static Transect Create()
        {
            return new Transect();
        }
    }

    public static class SurveyFixture
    {
        public static Survey Create()
        {
            return new Survey {Date = DateTime.Now};
        }
    }

    public static class WoodyDebrisFixture
    {
        public static WoodyDebris Create()
        {
            return new WoodyDebris();
        }
    }
}
