using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class GroundCover
    {
        public int Id { get; set; }

        [Required(ErrorMessage="You must have a parent {0} record")]
        [DisplayName("Survey")]
        public Survey Survey { get; set; }

        [Required(ErrorMessage="You must have at least one {0} record")]
        [DisplayName("Plot")]
        public IList<Plot> Plots { get; set; }
    }
}
