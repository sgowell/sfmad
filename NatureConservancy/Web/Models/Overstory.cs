using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class OverStory
    {
        [DisplayName("Notes")]
        public String Notes{ get; set;}
        public IList<OverstoryItem> OverStoryItems { get; set; }
        public IList<Snag> Snags{get;set;}
        public Microtopography Microtopography { get; set; }
    }
}
