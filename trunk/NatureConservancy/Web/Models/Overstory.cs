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
        public String Notes{ get; set;}

        public IList<OverstoryItem> OverstoryItems { get; set; }

        public virtual Survey Survey
        {
            get;
            set;
        }
        public IList<Snag> Snags{get;set;}
        public Microtopography Microtopography { get; set; }
        public Survey Survey { get; set; }
    }
}
