using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.DynamicData;

namespace Web.Models
{
    public class Understory
    {
        
        public Survey Survey
        {
            get; set;
        }

        public IList<UnderstoryItem> UnderstorySpecies
        {
            get; set;
        }
        
        [DisplayName("Notes")]
        public string Note
        {
            get; set;
        }
    }
}
