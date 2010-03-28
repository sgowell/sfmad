using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Site : Entity
    {
        [Required(ErrorMessage = "Please specify your {0} for this survey")]
        [DefaultValue("Two-Hearted River")]
        [DisplayName("Site Name")]
        public virtual string Name { get; set; }

        [Required(ErrorMessage = "Please enter at least one {0}")]
        public virtual IList<Stand> Stands { get; set; }
        public virtual int SiteNumber { get; set; }
        
        public virtual int RegionNumber { get; set; }

        [Required(ErrorMessage="You must have a parent {0} record")]
        [DisplayName("Ecological Region")]
        public virtual EcoRegion EcoRegion
        {
            get; set;
        }
    }
}
