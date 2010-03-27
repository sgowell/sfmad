using FluentNHibernate.Mapping;

namespace Web.Models.Mappings
{
    public class TransectMapping : ClassMap<Transect>
    {
        public TransectMapping()
        {
            Id(x => x.Id);
            Map(x => x.TransectNumber);
            Map(x => x.TransectClass);
            Map(x => x.Longitude);
            Map(x => x.Latitude);
            
        }
    }
}
