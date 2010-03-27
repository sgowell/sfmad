﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class WoodyDebris : Entity
    {
        [Required(ErrorMessage="Please enter a value for {0} in meters.")]
        [DisplayName("Total Length")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a valid {0} ")]
        public double TotalLength
        {
            get; set;
        }

        [Required(ErrorMessage = "Please enter a value for {0} in centimeters.")]
        [DisplayName("Intersect Diameter")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a valid {0} ")]
        public double IntersectDiameter
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please enter a value for {0} in centimeters.")]
        [DisplayName("Large End Diameter")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a valid {0} ")]
        public double LargeEndDiameter
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please enter a value for {0} in centimeters.")]
        [DisplayName("Small End Diameter")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a valid {0} ")]
        public double SmallEndDiameter
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Please select a {0}")]
        [DisplayName("Decay Class")]
        public WoodyDebrisDecayClass DecayClass
        {
            get;
            set;
        }

        [DisplayName("Species")]
        [Required(ErrorMessage = "Please select a {0}")]
        public Species Species
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
