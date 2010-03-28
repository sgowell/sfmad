using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class WoodyDebris : Entity
    {
        [Required(ErrorMessage="Please enter a value for {0} in meters.")]
        [DisplayName("Total Length")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a valid {0} ")]
        public virtual double TotalLength
        {
            get; set;
        }

        [Required(ErrorMessage = "Please enter a value for {0} in centimeters.")]
        [DisplayName("Intersect Diameter")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a valid {0} ")]
        public virtual double IntersectDiameter
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please enter a value for {0} in centimeters.")]
        [DisplayName("Large End Diameter")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a valid {0} ")]
        public virtual double LargeEndDiameter
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please enter a value for {0} in centimeters.")]
        [DisplayName("Small End Diameter")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a valid {0} ")]
        public virtual double SmallEndDiameter
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Please select a {0}")]
        [DisplayName("Decay Class")]
        public virtual WoodyDebrisDecayClass DecayClass
        {
            get;
            set;
        }

        [DisplayName("Species")]
        [Required(ErrorMessage = "Please select a {0}")]
        public virtual Species Species
        {
            get;
            set;
        }

        [Required(ErrorMessage = "You must have a parent {0} record.")]
        [DisplayName("Survey")]
        public virtual Survey Survey
        {
            get;
            set;
        }
    }
}
