using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Plot
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Please enter a {0}")]
        [DisplayName("Plot Name")]
        public string Name { get; set; }

        [DisplayName("Plot Description")]
        public string Description { get; set; }

        [Required(ErrorMessage="You must have a parent {0} record")]
        [DisplayName("Ground Cover")]
        public GroundCover GroundCover { get; set; }

        [Required(ErrorMessage = "You must have at least one {0} record")]
        [DisplayName("Plot Item")]
        public IList<PlotItem> PlotItems { get; set; }
    }
}
