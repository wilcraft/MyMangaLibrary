using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyMangaLibrary.Models
{
    public class Manga
    {
        public int ID { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, 10.00, ErrorMessage = "Rating cannot be more than 10!")]
        public decimal Rating { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "Name is too long!")]
        public string Name { get; set; } = null;
        public int ChapterCount { get; set; }
        public string Summary { get; set; }
    }
}
