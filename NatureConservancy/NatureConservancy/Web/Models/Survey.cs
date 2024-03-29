﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Web.Models
{
    public class Survey : Entity
    {
        [Required(ErrorMessage = "Please enter a {0}")]
        [DisplayName("Bearing")]
        [Range(0, 360, ErrorMessage = "Please enter a valid {0}. (0-360)")]
        public virtual int Bearing { get; set; } //Degrees zero to 360

        [Required(ErrorMessage = "Please enter a {0}")]
        [DisplayName("Stand")]
        [RegularExpression("^[A-G]", ErrorMessage = "Please enter a valid {0}. (A-G)")]
        public virtual string TransectClass { get; set; } //A-G

        [Required(ErrorMessage = "Please enter a {0}")]
        [DisplayName("Transect Number")]
        public virtual int TransectNumber { get; set; }

        [Required(ErrorMessage = "Please enter a {0}")]
        [DisplayName("Survey Start Time")]
        public virtual DateTime SurveyStartTime
        {
            get; set;
        }

        [Required(ErrorMessage = "Please enter a {0}")]
        [DisplayName("Survey End Time")]
        public virtual DateTime SurveyEndTime
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Please enter the {0}")]
        [DisplayName("Surveyors")]
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

        public virtual IList<Understory> Undertories
        {
            get;
            set;
        }
    }
}