using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class OverstoryItem
    {
        [DisplayName("Species")]
        [Required(ErrorMessage = "Please select a {0}")]
        public Species Species
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please enter the {0} for this species.")]
        [DisplayName("DBH (Diameter Breast Height)")]
        [DiameterBreastHeightAttribute(MinimumValue = 10.00, ErrorMessage = "Please enter a {0} greater than 10cm")]
        public double DiameterBreastHeight
        {
            get;
            set;
        }

        public Overstory Overstory 
        {
            get;
            set;
        }
    }

    public class DiameterBreastHeightAttribute : ValidationAttribute
    {
        public double MinimumValue { get; set; }

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }
            var dbh = (double)value;
            if (dbh < MinimumValue)
            {
                return false;
            }

            return true;
        }
    }
}
