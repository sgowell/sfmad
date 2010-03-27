using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class UnderstoryItem
    {
        [DisplayName("Species")]
        public Species Species
        {
            get;
            set;
        }
        [DisplayName("Tally")]
        public int Tally
        {
            get;
            set;
        }

        public Understory Understory 
        {
            get;
            set;
        }
    }
 }
