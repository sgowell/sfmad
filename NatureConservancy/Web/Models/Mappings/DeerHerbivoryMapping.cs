using FluentNHibernate.Mapping;

namespace Web.Models.Mappings
{
    public class DeerHerbivoryMapping : ClassMap<DeerHerbivory>
    {
        public DeerHerbivoryMapping()
        {
            Id(x => x.Id);
            Map(x => x.Browsed);
            Map(x => x.Unbrowsed);
            //HasOne(x => x.Species);
            //HasOne(x => x.Understory);
            ////HasOne(x => x.Survey);
        }
    }
}
