using System.Collections.Generic;

namespace Web.Models
{
    public class Understory
    {
        public Survey Survey
        {
            get; set;
        }

        public IList<UnderstorySpecies> UnderstorySpecies
        {
            get; set;
        }

        public string Note
        {
            get; set;
        }
    }
}
