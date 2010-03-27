using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Overstory : Entity
    {
        [DisplayName("Notes")]
        [UIHint("TextArea")]
        public virtual String Notes{ get; set;}

        public virtual IList<OverstoryItem> OverstoryItems { get; set; }

        public virtual Survey Survey
        {
            get;
            set;
        }
        public virtual IList<Snag> Snags { get; set; }
        public virtual Microtopography Microtopography { get; set; }
    }
}
