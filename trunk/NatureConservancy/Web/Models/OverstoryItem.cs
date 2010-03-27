using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class OverstoryItem
    {
        [DisplayName("Species")]
        public Species Species
        {
            get;
            set;
        }

        [DisplayName("DBH (Diameter Breast Height)")]
        public double DiameterBreastHeight
        {
            get;
            set;
        }

        public OverStory OverStory 
        {
            get;
            set;
        }

        [DisplayName("Notes")]
        public String Notes { get; set; }
    }
}
