using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Web.Models;

namespace Web.Models
{
    public class DeerHerbivory
    {
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

        public int Id
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        [DisplayName("Browsed")]
        public int Browsed
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        [DisplayName("Unbrowsed")]
        public int Unbrowsed
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        
        public Understory UnderStory { get; set; }
    }
}
