using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Data;

namespace NatureConservatory
{
    public class Entity
    {
        public virtual int Id { get; set; }
    }

    public class Transect : Entity
    {
        public virtual string TransectClass { get; set; } //A-G
        public virtual int TransectNumber { get; set; }
        public virtual IList<Survey> Surveys { get; set; }

        public virtual Stand Stands
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public virtual Double Latitude
        {
            get; set;
        }

        public virtual Double Longitude
        {
            get; set;
        }
        
    }
}
