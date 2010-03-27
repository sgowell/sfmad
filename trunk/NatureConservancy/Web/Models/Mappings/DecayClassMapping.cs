using FluentNHibernate.Mapping;

namespace Web.Models.Mappings
{
    public class WoodyDebrisDecayClassMapping :ClassMap<WoodyDebrisDecayClass>
    {
        public WoodyDebrisDecayClassMapping()
        {
            Id(x => x.Id);
            Map(x => x.Description);
            Map(x => x.Class);
        }
    }
    public class SnagDecayClassMapping :ClassMap<SnagDecayClass>
    {
        public SnagDecayClassMapping()
        {
            Id(x => x.Id);
            Map(x => x.DecayDescription);
            Map(x => x.DecayClass);
        }
    }

}
