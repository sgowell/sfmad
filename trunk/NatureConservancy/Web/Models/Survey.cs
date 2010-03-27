using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Web.Models
{
    public class Survey : Entity
    {
        [Required(ErrorMessage = "Please enter a bearing!")]
        [DisplayName("Bearing")]
        [Range(0, 360)]
        public virtual int Bearing { get; set; } //Degrees zero to 360

        [Required(ErrorMessage = "Please enter a Stand")]
        [DisplayName("Stand")]
        [RegularExpression("^[A-G]")]
        public virtual string TransectClass { get; set; } //A-G

        [Required(ErrorMessage = "Please enter a Transact Number")]
        [DisplayName("Number")]
        public virtual int TransectNumber { get; set; }

        [Required(ErrorMessage = "Enter a Start Time")]
        [DataType(DataType.DateTime)]
        [DisplayName("Survey Start")]
        [DisplayFormat(DataFormatString = "From:{0}")]
        public virtual DateTime SurveyStartTime
        {
            get; set;
        }

        [DataType(DataType.DateTime)]
        [DisplayName("Survey End")]
        [DisplayFormat(DataFormatString = "To:{0}")]
        public virtual DateTime SurveyEndTime
        {
            get;
            set;
        }

        [DisplayName("Surveyors:")]
        public virtual string Surveyors { get; set; }

        public virtual Transect Transect
        {
            get;
            set;
        }

        public virtual IList<Plot> Plots
        {
            get;
            set;
        }

        public virtual IList<WoodyDebris> WoodyDebris
        {
            get;
            set;
        }

        public virtual Microtopography Microtopography
        {
            get;
            set;
        }

        public virtual IList<Overstory> Overstory
        {
            get;
            set;
        }

        public virtual IList<Snag> Snags
        {
            get;
            set;
        }

        public virtual IList<DeerHerbivory> DeerHerbivory
        {
            get;
            set;
        }

        public virtual IList<UnderstorySpecies> UnderStorySpecies
        {
            get;
            set;
        }
    }
}