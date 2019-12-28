using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MacauTravelling.Models
{
    public class TourGuide
    {
        public int Id { get; set; }

        [StringLength(100), Display(Name = "Weather")]
        public string Weather { get; set; }

        [StringLength(10000), Display(Name = "VISA information"), DataType(DataType.MultilineText)]
        public string VISAInfo { get; set; }


        [StringLength(10000), Display(Name = "Macau information"), DataType(DataType.MultilineText)]
        public string MacInfo { get; set; }


        [Display(Name = "RMB to MOP")]
        public double? RMBRate { get; set; }

        [Display(Name = "HKD to MOP")]
        public double? HKDRate { get; set; }

        [Display(Name = "TWD to MOP")]
        public double? TWDRate { get; set; }

        [Display(Name = "USD to MOP")]
        public double? USDRate { get; set; }

        [Display(Name = "EUR to MOP")]
        public double? EURRate { get; set; }

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
