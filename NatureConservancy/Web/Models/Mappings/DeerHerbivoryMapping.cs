using FluentNHibernate.Mapping;

namespace Web.Models.Mappings
{
    public class DeerHerbivoryMapping : ClassMap<DeerHerbivory>
    {
        public DeerHerbivoryMapping()
        {
            Id(x => x.Id);
            Map(x => x.Browsed);
            HasOne(x => x.Species);
            HasOne(x => x.Survey);
        }
    }
}
