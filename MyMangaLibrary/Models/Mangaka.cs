using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyMangaLibrary.Models
{
    public class Mangaka
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(0, 120)]
        public int Age { get; set; }
        [StringLength(1000, ErrorMessage = "Description is too long!")]
        public string Description { get; set; }
    }
}
