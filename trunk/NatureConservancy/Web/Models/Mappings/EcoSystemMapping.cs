using FluentNHibernate.Mapping;

namespace Web.Models.Mappings
{
    public class EcoSystemMapping : ClassMap<EcoSystem>
    {
        public EcoSystemMapping()
        {
            Id(x => x.Id);
            Map(x => x.EcoSystemName);
        }
    }
}
