using System.Collections.Generic;

namespace Web.Models
{
    public class EcoRegion
    {
        public int RegionNumber { get; set; }
        public string Name { get; set; }
        public IList<Site> Sites { get; set; }

    }
}