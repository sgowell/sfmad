using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Understory : Entity
    {
        
        [Required(ErrorMessage = "You must have a parent {0} record.")]
        [DisplayName("Survey")]
        public virtual Survey Survey
        {
            get; set;
        }

        [Required(ErrorMessage = "You must have at least one {0} record.")]
        [DisplayName("UnderstoryItem")]
        public virtual IList<UnderstoryItem> UnderstoryItems
        {
            get; set;
        }
        
        [DisplayName("Notes")]
        public virtual string Note
        {
            get; set;
        }
    }
}
