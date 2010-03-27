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
        [DoubleAttribute(MinimumValue = 10.00, ErrorMessage = "Please enter a {0} greater than 10cm")]
        public double DiameterBreastHeight
        {
            get;
            set;
        }

        [Required(ErrorMessage = "You must have an {0} parent record.")]
        [DisplayName("Overstory")]
        public Overstory Overstory 
        {
            get;
            set;
        }
    }

    public class DoubleAttribute : ValidationAttribute
    {
        public double MinimumValue { get; set; }
        public double MaximumValue { get; set; }

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }
            var dval = (double)value;

                if (dval < MinimumValue)
                {
                    return false;
                }
          
                if (dval > MaximumValue)
                {
                    return false;
                }    
           
            return true;
        }
    }
}
