using System;
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
        [DisplayName("Survey Date")]
        public virtual DateTime Date
        {
            get; set;
        }

        [Required(ErrorMessage = "Please enter a {0}")]
        [DisplayName("Start Time")]
        public virtual string StartTime
        {
            get; set;
        }

        [Required(ErrorMessage = "Please enter a {0}")]
        [DisplayName("End Time")]
        public virtual string EndTime
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Please enter the {0}")]
        [DisplayName("Surveyors")]
        public virtual string Surveyors { get; set; }

        [Required(ErrorMessage = "You must have a parent {0} record")]
        [DisplayName("Transect")]
        public virtual Transect Transect
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public virtual bool Completed
        {
            get;
            set;
        }

        public virtual void  AddGroundCover(GroundCover groundCover)
        {
            GroundCover = groundCover;
            groundCover.Survey = this;
        }

        public virtual GroundCover GroundCover
        {
            get;
            set;
        }

        private IList<WoodyDebris> woodyDebris = new List<WoodyDebris>();

        public virtual IList<WoodyDebris> WoodyDebris
        {
            get { return woodyDebris; }
            set { woodyDebris = value; }
        }

        public virtual Microtopography Microtopography
        {
            get;
            set;
        }

        public virtual IList<Overstory> Overstories
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

        public virtual IList<Understory> Understories
        {
            get;
            set;
        }
    }
}