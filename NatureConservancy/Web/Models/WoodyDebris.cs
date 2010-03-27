using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Web.Models;

namespace Web.Models
{
    public class WoodyDebris
    {
        public double TotalLength
        {
            get; set;
        }

        public double IntersectDiameter
        {
            get;
            set;
        }

        public double LargeEndDiameter
        {
            get;
            set;
        }

        public double SmallEndDiameter
        {
            get;
            set;
        }

        public WoodyDebrisDecayClass DecayClass
        {
            get;
            set;
        }

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
