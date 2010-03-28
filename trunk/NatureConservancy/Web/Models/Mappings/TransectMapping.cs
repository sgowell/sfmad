using FluentNHibernate.Mapping;

namespace Web.Models.Mappings
{
    public class StandMapping : ClassMap<Stand>
    {
        public StandMapping()
        {
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }

    public class SurveyMapping : ClassMap<Survey>
    {
        public SurveyMapping()
        {
            Id(x => x.Id);
            Map(x => x.Bearing);
            Map(x => x.SurveyStartTime);
            Map(x => x.SurveyEndTime);
            HasOne(x => x.Transect);
            HasOne(x => x.GroundCover);
        }
    }
	public class UnderstoryMapping : ClassMap<Understory>
	{
	    public UnderstoryMapping()
	    {
	        Id(x => x.Id);
	    }
	}

    public class GroundCoverMapping : ClassMap<GroundCover>
    {
        public GroundCoverMapping()
        {
            Id(x => x.Id);
        }
    }

    public class OverstoryItemMapping : ClassMap<OverstoryItem>
    {
        public OverstoryItemMapping()
        {
            Id(x => x.Id);
        }

    }

    public class PlotItemMapping : ClassMap<PlotItem>
    {
        public PlotItemMapping()
        {
            Id(x => x.Id);
        }
    }
    public class UnderstoryItemMapping : ClassMap<UnderstoryItem>
    {
        public UnderstoryItemMapping()
        {
            Id(x => x.Id);
        }
    }
    public class WoodyDebrisMapping : ClassMap<WoodyDebris>
    {
        public WoodyDebrisMapping()
        {
            Id(x => x.Id);
        }
    }
    public class OverStoryMapping : ClassMap<Overstory>
    {
        public OverStoryMapping()
        {
            Id(x => x.Id);
        }
    }

    public class SnagMapping : ClassMap<Snag>
    {
        public SnagMapping()
        {
            Id(x => x.Id);
        }
    }
    public class TransectMapping : ClassMap<Transect>
    {
        public TransectMapping()
        {
            Id(x => x.Id);
            Map(x => x.Number);
            Map(x => x.Longitude);
            Map(x => x.Latitude);
            HasOne(x => x.Stand);
            HasMany(x => x.Surveys);
        }
    }
}
