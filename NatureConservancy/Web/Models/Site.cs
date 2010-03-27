using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Site : Entity
    {
<<<<<<< .mine
        public int Id { get; set; }

        [Required(ErrorMessage = "Please specity your {0} for this survey")]
        [DefaultValue("Two-Hearted River")]
        [DisplayName("Site Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter at least one {0}")]
        public IList<Stand> Stands { get; set; }
=======
        public virtual int SiteNumber { get; set; }
        public virtual string SiteName { get; set; }
        public virtual int RegionNumber { get; set; }
        public virtual IList<Stand> Stands { get; set; }
>>>>>>> .r91

<<<<<<< .mine
        [Required(ErrorMessage="You must have a parent {0} record")]
        [DisplayName("Ecological Region")]
        public EcoRegion EcoRegion
=======
        public virtual EcoRegion EcoRegion
>>>>>>> .r91
        {
            get; set;
        }
    }
}
