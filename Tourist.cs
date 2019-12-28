using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MacauTravelling.Models
{
    public class Tourist
    {
        public int Id {get; set; }

        [StringLength(100), Display(Name = "Password"),DataType(DataType.Password)]
        public string Password { get; set; }

        [StringLength(100), Display(Name = "Name")]
        public string TouristName { get; set; }

  
    }
}
