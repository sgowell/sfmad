namespace Web.Models
{
    //*Decay Classes: 
    //I – recent cwd, leaves present, solid, and round; 
    //II – solid cwd, leaves absent, and round; 
    //III – solid or decayed cwd, leaves absent, solid or punky wood, round or oval; 
    //IV – decayed cwd, leaves absent, punky wood, oval; and V – very decayed cwd, leaves absent, punky wood, oval or collapsed shape (Tyrell and Crow 1994).                                  

    public class WoodyDebrisDecayClass : Entity
    {
        public virtual string Description
        {
            get;
            set;
        }

        public virtual string Class
        {
            get;
            set;
        }
    }

    //Decay classes: 
    //I - bark intact, small branches present; 
    //II - bark loose or sloughing, no sapwood degradation; 
    //III - little to no bark, sapwood degradation; 
    //IV - no bark, extensive sapwood degradation.

    public class SnagDecayClass : Entity
    {
        public virtual string DecayDescription
        {
            get;
            set;
        }

        public virtual string DecayClass
        {
            get;
            set;
        }
    }
}