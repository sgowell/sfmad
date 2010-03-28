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
    public static class UnderstoryFixture
    {
        public static Understory Create()
        {
            return new Understory();
        }
    }
    public static class UnderstoryItemFixture
    {
        public static UnderstoryItem Create()
        {
            return new UnderstoryItem();
        }
    }

    public static class PlotFixture
    {
        public static Plot Create()
        {
            return new Plot();
        }
    }

    public static class PlotItemFixture
    {
        public static PlotItem Create()
        {
            return new PlotItem();
        }
    }

    public static class GroundCoverFixture
    {
        public static GroundCover Create()
        {
            return new GroundCover();
        }
    }
}
