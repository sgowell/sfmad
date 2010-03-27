using FluentNHibernate.Mapping;


namespace Web.Models.Mappings
{
    public class PlotMapping : ClassMap<Plot>
    {
        PlotMapping()
        {
            Id(x => x.Id);
        }
    }
}
