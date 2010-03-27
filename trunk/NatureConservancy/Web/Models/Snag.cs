using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Web.Models;

namespace Web.Models
{
    public class Snag
    {
        public int SnagId
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        [DisplayName("Species")]
        public Species Species
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        [DisplayName("DBH")]
        public double DBH
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        [DisplayName("Height")]
        public double Height
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        [DisplayName("Decay Class")]
        public SnagDecayClass SnagDecayClass
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Survey Survey
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
