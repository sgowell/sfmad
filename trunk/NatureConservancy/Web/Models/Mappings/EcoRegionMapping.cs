﻿using FluentNHibernate.Mapping;

namespace Web.Models.Mappings
{
    public class StandMapping : ClassMap<Stand>
    {
        public StandMapping()
        {
            Id(x => x.Id);
            Map(x => x.Number);
            Map(x => x.SiteNumber);
            Map(x => x.EcoSystem);
            Map(x => x.TreatmentType);
        }

    }
    
    public class SiteMapping : ClassMap<Site>
    {
        public SiteMapping()
        {
            Id(x => x.Id);
            Map(x => x.SiteNumber);
            Map(x => x.SiteName);
            Map(x => x.RegionNumber);
        }
    }

    public class EcoRegionMapping : ClassMap<EcoRegion>
    {
        public EcoRegionMapping()
        {
            Id(x => x.Id);
            Map(x => x.RegionNumber);
            Map(x => x.Name);
            //Map(x => x.Sites);
        }
    }
}
