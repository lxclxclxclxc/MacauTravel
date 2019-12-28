using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MacauTravelling.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [StringLength(1000), Display(Name = "Comment Content")]
        public string Content { get; set; }

        [Display(Name = "Comment Date"),DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Comment Like")]
        public int Like { get; set; }

        public int CommentedID { get; set; }

        public int WriterID { get; set; }

    }
}
