using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NatureConservatory
{
    public class Survey
    {
        [Required]
        [DisplayName("Bearing")]
        [Range(0, 360)]
        public int Bearing { get; set; } //Degrees zero to 360

        [DisplayName("Stand")]
        [RegularExpression("^[A-G]")]
        public string TransectClass { get; set; } //A-G

        [DisplayName("Number")]
        public int TransectNumber { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Survey Start")]
        [DisplayFormat(DataFormatString="From:{0}")]
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

        [DataType(DataType.DateTime)]
        [DisplayName("Survey End")]
        [DisplayFormat(DataFormatString = "To:{0}")]
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
