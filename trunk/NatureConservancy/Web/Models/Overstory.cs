namespace Web.Models
{
    public class Overstory
    {
        public Species Species
        {
            get;
            set;
        }

        public double DiameterBreastHeight
        {
            get;
            set;
        }

        public Survey Survey
        {
            get;
            set;
        }
    }

    public class UnderStorySpecies
    {
        public Species Species
        {
            get;
            set;
        }

        public int Tally
        {
            get;
            set;
        }

        public Survey Survey
        {
            get;
            set;
        }
    }
}
