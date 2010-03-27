using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class DeerHerbivory : Entity
    {
        [DisplayName("Species")]
        [Required(ErrorMessage = "Please select a {0}")]
        public Species Species
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
        [Required(ErrorMessage = "Please enter an {0} Amount")]
        public int Unbrowsed
        {
            get;
            set;
        }

        [Required(ErrorMessage = "You must have a parent {0} record.")]
        [DisplayName("Understory")]
        public Understory Understory { get; set; }
    }
}
