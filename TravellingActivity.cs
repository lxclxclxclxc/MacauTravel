using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace MacauTravelling.Models
{
    public class TravellingActivity
    {
        public int Id { get; set; }

        [StringLength(100), Display(Name = "Name")]
        public string ActivityName { get; set; }

        [StringLength(10000), Display(Name = "Route Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Open Date"),DataType(DataType.Date)]
        public DateTime OpenDate { get; set; }

        public int ItemId1 { get; set; }
        public int ItemId2 { get; set; }
        public int ItemId3{ get; set; }
        public int ItemId4{ get; set; }
        public int ItemId5{ get; set; }
        public int ItemId6 { get; set; }
        public int ItemId7 { get; set; }
        public int ItemId8 { get; set; }
        public int ItemId9 { get; set; }

    }
}
