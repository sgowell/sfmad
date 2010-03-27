using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Web.Models;

namespace Web.Models
{
    public class DeerHerbivory
    {
        [DisplayName("Species")]
        [Required(ErrorMessage = "Please select a {0}")]
        public Species Species
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        [DisplayName("Browsed")]
        [Required(ErrorMessage = "Please enter a {0} Amount")]
        public int Browsed
        {
            get;
            set;
        }

        [DisplayName("Unbrowsed")]
        [Required(ErrorMessage = "Please enter a {0} Amount")]
        public int Unbrowsed
        {
            get;
            set;
        }


        public Understory Understory { get; set; }
    }
}
