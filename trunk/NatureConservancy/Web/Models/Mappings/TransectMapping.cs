﻿using FluentNHibernate.Mapping;

namespace Web.Models.Mappings
{

//    public class SurveyMapping : ClassMap<Survey>
//    {
//        public SurveyMapping()
//        {
//            Id(x => x.Id);
//            Map(x => x.Bearing);
//        }
//    }

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
            //HasOne(x => x.Stand);
            //Map(x => x.Stands, new Stand());
        }
    }
}