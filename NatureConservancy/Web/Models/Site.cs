using System.Collections.Generic;

namespace Web.Models
{
    public class Site : Entity
    {
        public virtual int SiteNumber { get; set; }
        public virtual string SiteName { get; set; }
        public virtual int RegionNumber { get; set; }
        public virtual IList<Stand> Stands { get; set; }

        public virtual EcoRegion EcoRegion
        {
            get; set;
        }
    }
}
