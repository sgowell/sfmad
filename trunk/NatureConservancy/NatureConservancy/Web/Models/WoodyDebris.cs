using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Web.Models;

namespace Web.Models
{
    public class WoodyDebris
    {
        [DisplayName("Total Length")]
        public double TotalLength
        {
            get; set;
        }

        [DisplayName("Intersect Diameter")]
        public double IntersectDiameter
        {
            get;
            set;
        }

        [DisplayName("Large End Diameter")]
        public double LargeEndDiameter
        {
            get;
            set;
        }

        [DisplayName("Small End Diameter")]
        public double SmallEndDiameter
        {
            get;
            set;
        }

        [DisplayName("Decay Class")]
        public WoodyDebrisDecayClass DecayClass
        {
            get;
            set;
        }

        [DisplayName("Species")]
        public Species Species
        {
            get;
            set;
        }


        public Survey Survey
        {
            get;
            set;
        }
    }
}
