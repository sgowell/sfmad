using FluentNHibernate.Mapping;

namespace Web.Models.Mappings
{
    public class MicrotopographyMapping : ClassMap<Microtopography>
    {
        public MicrotopographyMapping()
        {
            Id(x => x.Id);
            Map(x => x.MicrotopographyId);
            Map(x => x.Comments);
            HasOne(x => x.DevelopmentIntensity);
            HasOne(x => x.Survey);
        }
    }
}
