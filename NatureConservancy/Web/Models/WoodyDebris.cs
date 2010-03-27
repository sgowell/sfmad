using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class WoodyDebris : Entity
    {
        [Required(ErrorMessage="Please enter a value for {0} in meters.")]
        [DisplayName("Total Length")]
        public double TotalLength
        {
            get; set;
        }

        [Required(ErrorMessage = "Please enter a value for {0} in centimeters.")]
        [DisplayName("Intersect Diameter")]
        public double IntersectDiameter
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please enter a value for {0} in centimeters.")]
        [DisplayName("Large End Diameter")]
        public double LargeEndDiameter
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please enter a value for {0} in centimeters.")]
        [DisplayName("Small End Diameter")]
        public double SmallEndDiameter
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Please select a {0}")]
        [DisplayName("Decay Class")]
        public WoodyDebrisDecayClass DecayClass
        {
            get;
            set;
        }

        [DisplayName("Species")]
        public Species Species
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
