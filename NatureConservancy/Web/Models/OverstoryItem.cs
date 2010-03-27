using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class OverstoryItem : Entity
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
        [Range(10.00, double.MaxValue, ErrorMessage = "Please enter a {0} greater than 10cm")]
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
}
