using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class GroundCover : Entity
    {

        [Required(ErrorMessage="You must have a parent {0} record")]
        [DisplayName("Survey")]
        public virtual Survey Survey { get; set; }

        [Required(ErrorMessage="You must have at least one {0} record")]
        [DisplayName("Plot")]
        public virtual IList<Plot> Plots { get; set; }

        public virtual void Add(Plot plot)
        {
            if (Plots == null)
                Plots = new List<Plot>();
            Plots.Add(plot);
            plot.GroundCover = this;
        }
    }
}
