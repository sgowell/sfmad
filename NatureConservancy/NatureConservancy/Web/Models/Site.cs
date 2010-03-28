using System.Collections.Generic;

namespace Web.Models
{
    public class Site
    {
        public int SiteNumber { get; set; }
        public string SiteName { get; set; }
        public int RegionNumber { get; set; }
        public IList<Stand> Stands { get; set; }

        public EcoRegion EcoRegion
        {
            get; set;
        }
    }
}
