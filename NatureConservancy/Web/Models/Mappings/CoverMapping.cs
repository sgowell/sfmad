using FluentNHibernate.Mapping;

namespace Web.Models.Mappings
{
    public class CoverMapping : ClassMap<Cover>
    {
        public CoverMapping()
        {
            Id(x => x.Id);
            Map(x => x.Class);
            Map(x => x.Description);
        }
    }
}
