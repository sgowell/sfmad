using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class UnderstoryItem : Entity
    {
        [Required(ErrorMessage = "Please select a {0}")]
        [DisplayName("Species")]
        public virtual Species Species
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please enter a {0} for this record")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a valid {0}")]
        [DisplayName("Tally")]
        public virtual int Tally
        {
            get;
            set;
        }

        [Required(ErrorMessage = "You must have a parent {0} record")]
        [DisplayName("Understory")]
        public virtual Understory Understory 
        {
            get;
            set;
        }
    }
 }
