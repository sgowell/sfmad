using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class PlotItem
    {
        [Required(ErrorMessage="You must have a parent {0} record")]
        [DisplayName("Plot")]
        public Plot Plot
        {
            get;
            set;
        }

        [Required(ErrorMessage = "You must select a {0}")]
        [DisplayName("Species")]
        public Species Species
        {
            get;
            set;
        }

        [Required(ErrorMessage = "You must select a {0}")]
        [DisplayName("Cover Class")]
        public PlotCover CoverClass { get; set; }

        public enum PlotCover
        {
            /// <summary>
            /// I (0-1%)
            /// </summary>
            Class1,
            /// <summary>
            /// II (2-5%)
            /// </summary>
            Class2,
            /// <summary>
            /// III (6-25%)
            /// </summary>
            Class3,
            /// <summary>
            /// IV (26-50%)
            /// </summary>
            Class4,
            /// <summary>
            /// V (51-75%)
            /// </summary>
            Class5,
            /// <summary>
            /// VI (76-95%)
            /// </summary>
            Class6,
            /// <summary>
            /// VII (96-100%)
            /// </summary>
            Class7,
        }
    }
}
