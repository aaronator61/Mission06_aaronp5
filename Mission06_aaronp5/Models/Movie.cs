using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_aaronp5.Models
{
    //Movie table with each of its fields
    public class Movie
    {
        [Key]
        [Required]
        public int movieId { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string director { get; set; }
        [Required]
        public string rating { get; set; }
        [Required]
        public bool edited { get; set; }
        public string lentTo { get; set; }
        [MaxLength(25)]
        public string note { get; set; }
    }
}
