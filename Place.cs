using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MacauTravelling.Models
{
    public class Place
    {
        public int Id { get; set; }

        [StringLength(100), Display(Name = "Name")]
        public string PlaceName { get; set; }

        [StringLength(100), Display(Name = "Location")]
        public string PlaceLocation { get; set; }

        [StringLength(10000), Display(Name = "Place Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Price"),DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public double? UnitPrice { get; set; }

        [Column(TypeName = "decimal(1, 1)")]
        [Display(Name = "Score")]
        public double Score { get; set; }

        [Display(Name = "ContactNumber"),DataType(DataType.PhoneNumber)]
        public int? ContactNumber { get; set; }

        [Display(Name = "Type")]
        public string PlaceType { get; set; }

        [DataType(DataType.ImageUrl)]
        public string ImagePath1 { get; set; }
        [DataType(DataType.ImageUrl)]
        public string ImagePath2 { get; set; }
        [DataType(DataType.ImageUrl)]
        public string ImagePath3 { get; set; }
        [DataType(DataType.ImageUrl)]
        public string ImagePath4 { get; set; }
        [DataType(DataType.ImageUrl)]
        public string ImagePath5 { get; set; }
        [DataType(DataType.ImageUrl)]
        public string ImagePath6 { get; set; }
        [DataType(DataType.ImageUrl)]
        public string ImagePath7 { get; set; }
        [DataType(DataType.ImageUrl)]
        public string ImagePath8 { get; set; }
        [DataType(DataType.ImageUrl)]
        public string ImagePath9 { get; set; }
    }
}
