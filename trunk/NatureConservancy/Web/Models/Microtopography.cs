using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Microtopography : Entity
    {
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
        [DisplayName("Development Intensity")]
        public virtual MicrotopographyAmount DevelopmentIntensity
        {
            get; set;
        }

        [Required(ErrorMessage = "You must have a parent {0} record.")]
        [DisplayName("Overstory")]
        public virtual Overstory Overstory
        {
            get; set;
        }
    }
}
