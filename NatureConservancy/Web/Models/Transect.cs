using System;
using System.Collections.Generic;

namespace Web.Models
{
    public class Entity
    {
        public virtual int Id { get; set; }
    }

    public class Transect : Entity
    {
        public virtual string TransectClass { get; set; } //A-G
        public virtual int Number { get; set; }
        public virtual IList<Survey> Surveys { get; set; }

        public virtual Stand Stand
        { get; set; }

        public virtual Double Latitude
        { get; set; }

        public virtual Double Longitude
        {
            get; set;
        }
        
    }
}
