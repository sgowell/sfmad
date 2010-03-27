using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Snag
    {
        public int SnagId
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please select a {0}")]
        [DisplayName("Species")]
        public Species Species
        { get; set; }


        [Required(ErrorMessage = "Please enter the {0} for this species.")]
        [DisplayName("DBH (Diameter Breast Height)")]
        [Range(10.00, double.MaxValue, ErrorMessage = "Please enter a {0} greater than 10cm")]
        public double DiameterBreastHeight
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please enter the {0} for this species.")]
        [DisplayName("Height")]
        [Range(2.00, double.MaxValue, ErrorMessage = "Please enter a {0} greater than 2m")]
        public double Height
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please select a {0}")]
        [DisplayName("Decay Class")]
        public SnagDecayClass SnagDecayClass
        {
            get;
            set;
        }

        [Required(ErrorMessage = "You must have a parent {0} record")]
        public Survey Survey
        {
            get;
            set;
        }
    }
}
