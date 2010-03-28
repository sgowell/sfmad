using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Overstory
    {
        [DisplayName("Notes")]
        [UIHint("TextArea")]
        public String Notes{ get; set;}

        public IList<OverstoryItem> OverstoryItems { get; set; }

        public IList<Snag> Snags{get;set;}
        public Microtopography Microtopography { get; set; }
    }
}
