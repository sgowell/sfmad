using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Plot : Entity
    {
        [Required(ErrorMessage="Please enter a {0}")]
        [DisplayName("Plot Name")]
        public virtual string Name { get; set; }

        [DisplayName("Plot Description")]
        public virtual string Description { get; set; }

        [Required(ErrorMessage="You must have a parent {0} record")]
        [DisplayName("Ground Cover")]
        public virtual GroundCover GroundCover { get; set; }

        [Required(ErrorMessage = "You must have at least one {0} record")]
        [DisplayName("Plot Item")]
        public virtual IList<PlotItem> PlotItems { get; set; }

        public virtual void Add(PlotItem pItem)
        {
            if (PlotItems == null)
            {
                PlotItems = new List<PlotItem>();
            }
            PlotItems.Add(pItem);
            pItem.Plot = this;
        }
    }
}
