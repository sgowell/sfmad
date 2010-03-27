namespace Web.Models
{
    public enum WoodyDebrisDecayClass
    {
        /// <summary>
        /// 
        /// </summary>
        Class1,
        /// <summary>
        /// 
        /// </summary>
        Class2,
        /// <summary>
        /// III – solid or decayed cwd, leaves absent, solid or punky wood, round or oval
        /// </summary>
        Class3,
        /// <summary>
        /// IV – decayed cwd, leaves absent, punky wood, oval; and V – very decayed cwd, leaves absent, punky wood, oval or collapsed shape (Tyrell and Crow 1994)
        /// </summary>
        Class4,
    }

    public enum SnagDecayClass
    {
        /// <summary>
        /// I - bark intact, small branches present
        /// </summary>
        Class1,
        /// <summary>
        /// II - bark loose or sloughing, no sapwood degradation
        /// </summary>
        Class2,
        /// <summary>
        /// III - little to no bark, sapwood degradation
        /// </summary>
        Class3,
        /// <summary>
        /// IV - no bark, extensive sapwood degradation
        /// </summary>
        Class4,
    }
}