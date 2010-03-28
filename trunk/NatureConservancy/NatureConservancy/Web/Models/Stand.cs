using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Web.Models
{
    public class Stand : Entity
    {
        public virtual int Number { get; set; } //Unique number
        public virtual string SiteNumber { get; set; } //The site this stand belongs to
        
        public virtual string EcoSystem { get; set; } 
        public virtual string TreatmentType{get;set;} //Lookup
        public virtual IList<Transect> Transects { get; set; }

        public virtual Site Site
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
