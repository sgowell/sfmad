namespace Web.Models
{
    public abstract class Entity
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
            if(obj as Entity == null) return false;
            return (obj as Entity).Id.Equals(this.Id);
        }
    }
}
