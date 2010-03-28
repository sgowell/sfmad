using System;
using System.Collections.Generic;

namespace Web.Models
{
    public class Entity
    {
        public virtual int Id { get; set; }

        public override string ToString()
        {
            return GetType().Name + " [" + Id + "]";
        }


        /// <summary>
        /// If two objects are the same type and their Ids are equal, then they are equal.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            // todo: check equality taking into account 
            // nhibernate proxies
            //if (obj.GetType() != GetType()) return false;

            return (obj as Entity).Id.Equals(this.Id);
        }
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
