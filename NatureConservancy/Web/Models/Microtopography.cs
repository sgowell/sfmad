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

        public String Comments
        {
            get; set;
        }

        public enum MicrotopographyAmount
        {
            /// <summary>
            /// None
            /// </summary>
            None,
            /// <summary>
            /// Minor - Less than 10%
            /// </summary>
            Minor,
            /// <summary>
            /// Moderate - 10-50%
            /// </summary>
            Moderate,
            /// <summary>
            /// Major - Greater than 50%
            /// </summary>
            Major,

        }

        [Required(ErrorMessage = "Please select the {0}")]
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
