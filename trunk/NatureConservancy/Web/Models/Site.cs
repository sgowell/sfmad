using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatureConservatory
{
    public class Site
    {
        public int SiteNumber { get; set; }
        public string SiteName { get; set; }
        public int RegionNumber { get; set; }
        public IList<Stand> Stands { get; set; }

        public EcoRegion EcoRegion
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
