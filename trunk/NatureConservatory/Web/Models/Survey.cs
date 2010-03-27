using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatureConservancy.Web.Models
{
    class Survey
    {
        public int Bearing { get; set; } //Degrees zero to 360
        public string TransectClass { get; set; } //A-G
        public int TransectNumber { get; set; }

        public DateTime SurveyStartTime
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DateTime SurveyEndTime
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IList<Surveyors> Surveyors
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Transect Transect
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IList<Plot> Plots
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IList<WoodyDrebis> WoodyDebries
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Microtopography Microtopography
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IList<Overstory> Overstory
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IList<Snag> Snags
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IList<DeerHerbivory> DeerHerbivory
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IList<UnderStorySpecies> UnderStorySpecies
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
