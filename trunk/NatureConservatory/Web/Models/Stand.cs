using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatureConservancy.Web.Models
{
    class Stand
    {
        public int StandNumber { get; set; } //Unique number
        public string SiteNumber { get; set; } //The site this stand belongs to
        
        public string EcoSystem { get; set; } 
        public string TreatmentType{get;set;} //Lookup
        public IList<Transect> Transects { get; set; }

        public Site Site
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
