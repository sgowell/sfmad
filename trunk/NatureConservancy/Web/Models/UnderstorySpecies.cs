using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class UnderstorySpecies : Species
    {
        public Species Species
        {
            get;
            set;
        }

        public int Tally
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
