using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatureConservatory
{
    class EcoRegion
    {
        public int RegionNumber { get; set; }
        public string Name { get; set; }
        public IList<Site> Sites { get; set; }

    }
}
