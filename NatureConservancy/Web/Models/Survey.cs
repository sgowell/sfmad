using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Web.Models
{
    public class Survey
    {
        [Required(ErrorMessage = "Please enter a bearing!")]
        [DisplayName("Bearing")]
        [Range(0, 360)]
        public int Bearing { get; set; } //Degrees zero to 360

        [Required(ErrorMessage = "Please enter a Stand")]
        [DisplayName("Stand")]
        [RegularExpression("^[A-G]")]
        public string TransectClass { get; set; } //A-G

        [Required(ErrorMessage = "Please enter a Transact Number")]
        [DisplayName("Number")]
        public int TransectNumber { get; set; }

        [Required(ErrorMessage = "Enter a Start Time")]
        [DataType(DataType.DateTime)]
        [DisplayName("Survey Start")]
        [DisplayFormat(DataFormatString = "From:{0}")]
        public DateTime SurveyStartTime
        {
            get; set;
        }

        [DataType(DataType.DateTime)]
        [DisplayName("Survey End")]
        [DisplayFormat(DataFormatString = "To:{0}")]
        public DateTime SurveyEndTime
        {
            get;
            set;
        }

        [DisplayName("Surveyors:")]
        public string Surveyors { get; set; }

        public Transect Transect
        {
            get;
            set;
        }

        public IList<Plot> Plots
        {
            get;
            set;
        }

        public IList<WoodyDebris> WoodyDebris
        {
            get;
            set;
        }

        public Microtopography Microtopography
        {
            get;
            set;
        }

        public IList<Overstory> Overstory
        {
            get;
            set;
        }

        public IList<Snag> Snags
        {
            get;
            set;
        }

        public IList<DeerHerbivory> DeerHerbivory
        {
            get;
            set;
        }

        public IList<Understory> Understory
        {
            get;
            set;
        }
    }
}