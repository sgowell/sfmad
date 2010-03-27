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
        [Required(ErrorMessage="Please enter a bearing!")]
        [DisplayName("Bearing")]
        [Range(0, 360)]
        public int Bearing { get; set; } //Degrees zero to 360

        [Required(ErrorMessage="Please enter a Stand")]
        [DisplayName("Stand")]
        [RegularExpression("^[A-G]")]
        public string TransectClass { get; set; } //A-G

        [Required(ErrorMessage = "Please enter a Transact Number")]
        [DisplayName("Number")]
        public int TransectNumber { get; set; }

        [Required(ErrorMessage = "Enter a Start Time")]
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

        [DisplayName("Surveyors:")]
        public string Surveyors { get; set; }

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
