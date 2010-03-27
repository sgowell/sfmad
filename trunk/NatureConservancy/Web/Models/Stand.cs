using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Stand : Entity
    {
        [Required(ErrorMessage = "You must have a parent {0} record")]
        [DisplayName("Site")]
        public virtual Site Site { get; set; }

        [Required(ErrorMessage = "Please enter a {0}")]
        [DisplayName("Stand")]
        [RegularExpression("^[A-G]", ErrorMessage = "Please enter a valid {0}. (A-G)")]
        public virtual string Name { get; set; } //A-G

        [Required(ErrorMessage = "Please enter a {0}")]
        [DisplayName("Ecosystem")]
        public virtual string EcoSystem { get; set; }

        public enum TreatmentType
        {
            /// <summary>
            /// Control (no harvest)
            /// </summary>
            ControlNoHarvest,
            /// <summary>
            /// Single tree selection harvest
            /// </summary>
            SingleTreeSelection,
            /// <summary>
            /// 60-ft gaps
            /// </summary>
            Gaps60,
            /// <summary>
            /// 90-ft gaps
            /// </summary>
            Gaps90,
            /// <summary>
            /// 120-ft gaps
            /// </summary>
            Gaps120,
        }

        [Required(ErrorMessage = "Please select a {0}")]
        [DisplayName("Treatment")]
        public virtual TreatmentType Treatment { get; set; }

        [Required(ErrorMessage = "Please add at least one {0}")]
        [DisplayName("Transect")]
        public virtual IList<Transect> Transects { get; set; }
    }
}
