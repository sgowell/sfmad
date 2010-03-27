using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class EcoRegion : Entity
    {
        [Required(ErrorMessage = "Please enter a {0}")]
        [DisplayName("Region Number")]
        public virtual int RegionNumber { get; set; }

        [Required(ErrorMessage = "Please enter a {0}")]
        [DisplayName("Region Name")]
        public virtual string Name { get; set; }

        [Required(ErrorMessage = "You must have at least one {0} record")]
        [DisplayName("Site")]
        public IList<Site> Sites { get; set; }

    }
}