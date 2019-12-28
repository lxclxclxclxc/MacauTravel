using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MacauTravelling.Models
{
    public class Map
    {
        
        public int Id { get; set; }

        [StringLength(100), Display(Name = "Name")]
        public string MapName { get; set; }

        [StringLength(10000), Display(Name = "Map Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }
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
