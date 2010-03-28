using FluentNHibernate.Mapping;

namespace Web.Models.Mappings
{
    public class OverstoryMapping : ClassMap<Overstory>
    {
        public OverstoryMapping()
        {
            Id(x => x.Id);
            Map(x => x.Notes);
            ////HasOne(x => x.Species);
            //Map(x => x.DiameterBreastHeight);
            //HasOne(x => x.Survey);
        }

    }
}
