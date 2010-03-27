using System;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Microtopography
    {
        [Required]
        public int MicrotopographyId
        {
            get; set;
        }

        [Required(ErrorMessage="Please enter {0}")]
        public String Comments
        {
            get; set;
        }

        [Required(ErrorMessage = "Please enter the {0}")]
        public MicrotopographyAmount DevelopmentIntensity
        {
            get; set;
        }

        [Required]
        public Survey Survey
        {
            get; set;
        }
    }
}
