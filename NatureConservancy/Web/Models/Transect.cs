using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Transect : Entity
    {
        [Required(ErrorMessage = "Please enter a {0}")]
        [DisplayName("Stand")]
        [RegularExpression("^[A-G]", ErrorMessage = "Please enter a valid {0}. (A-G)")]
        public virtual string TransectClass { get; set; } //A-G

        [Required(ErrorMessage = "Please enter a {0}")]
        [DisplayName("Transect Number")]
        [Range(1,Int32.MaxValue, ErrorMessage = "Please enter a positive value")]
        public virtual int Number { get; set; }

        public virtual IList<Survey> Surveys { get; set; }

        [Required(ErrorMessage = "You must have a parent {0} record")]
        [DisplayName("Stand")]
        public virtual Stand Stand { get; set; }

        [Required(ErrorMessage = "Please enter a {0} value for this record")]
        [Range(0.00, 90.00, ErrorMessage = "Please enter a valid {0}")]
        public virtual Double Latitude { get; set; }

        [Required(ErrorMessage = "Please enter a {0} value for this record")]
        [Range(0.00, 180.00, ErrorMessage = "Please enter a valid {0}")]
        public virtual Double Longitude { get; set; }

    }
}
