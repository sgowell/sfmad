﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Web.Models
{
    public class EcoRegion : Entity
    {
        [Required(ErrorMessage = "Please enter a {0}")]
        [DisplayName("Region Number")]
        public virtual int RegionNumber { get; set; }

        [Required(ErrorMessage = "Please enter a {0}")]
        [DisplayName("Region Name")]
        public virtual string Name { get; set; }

        [Required(ErrorMessage = "You must have at least one {0} record")]
        [DisplayName("Site")]
        public virtual IList<Site> Sites { get; set; }

        
        private static List<EcoRegion >  allEcoRegions = new List<EcoRegion >();

        public static List<EcoRegion> AllEcoRegions
        {
            get { return allEcoRegions; }
            set { allEcoRegions = value; }
        }


    }
}