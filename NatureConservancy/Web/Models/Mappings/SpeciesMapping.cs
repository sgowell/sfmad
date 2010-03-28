using FluentNHibernate.Mapping;


namespace Web.Models.Mappings
{
    public class SpeciesMapping : ClassMap<Species>
    {
        public SpeciesMapping()
        {
            Id(x => x.Id);
            Map(x => x.Acronym);
            Map(x => x.ScientificName);
            Map(x => x.CommonName);
            //todo consider AllSpecies
        }
    }
}
