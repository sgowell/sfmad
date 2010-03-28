using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Overstory : Entity
    {
        [DisplayName("Notes")]
        [UIHint("TextArea")]
        public virtual string Notes{ get; set;}

        public virtual void Add(OverstoryItem oItem)
        {
            if (OverstoryItems == null)
            {
                OverstoryItems = new List<OverstoryItem>();
            }
            OverstoryItems.Add(oItem);
            oItem.Overstory = this;
        }

        [Required(ErrorMessage = "You must have at least one {0} record.")]
        [DisplayName("Overstory Item")]
        public virtual IList<OverstoryItem> OverstoryItems { get; set; }

        [Required(ErrorMessage = "You must have a parent {0} record.")]
        [DisplayName("Survey")]
        public virtual Survey Survey { get; set; }

        [Required(ErrorMessage = "You must have one {0} record.")]
        [DisplayName("Snag")]
        public virtual IList<Snag> Snags { get; set; }

        [Required(ErrorMessage = "You must have one {0} record.")]
        [DisplayName("Microtopography")]
        public virtual Microtopography Microtopography { get; set; }
    }
}
