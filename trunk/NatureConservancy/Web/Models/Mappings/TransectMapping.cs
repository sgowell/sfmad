using FluentNHibernate.Mapping;

namespace Web.Models.Mappings
{
    public class StandMapping : ClassMap<Stand>
    {
        public StandMapping()
        {
            Id(x => x.Id);
            Map(x => x.Number);
        }
    }
    public class TransectMapping : ClassMap<Transect>
    {
        public TransectMapping()
        {
            Id(x => x.Id);
            Map(x => x.Number);
            Map(x => x.TransectClass);
            Map(x => x.Longitude);
            Map(x => x.Latitude);
            //Map(x => x.Stands, new Stand());
        }
    }
}
