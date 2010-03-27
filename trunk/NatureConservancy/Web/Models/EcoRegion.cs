using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class EcoRegion
    {
        [Required(ErrorMessage = "Please enter a {0}")]
        [DisplayName("Region Number")]
        public int RegionNumber { get; set; }

        [Required(ErrorMessage = "Please enter a {0}")]
        [DisplayName("Region Name")]
        public string Name { get; set; }

        public IList<Site> Sites { get; set; }

    }
}