using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatureConservancy.Web.Models
{
    class Transect
    {
        public string TransectClass { get; set; } //A-G
        public int TransectNumber { get; set; }
        public IList<Survey> Surveys { get; set; }

        public Stand Stands
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Double GPSLocationLatitude
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Double GPSLocationLongitude
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
