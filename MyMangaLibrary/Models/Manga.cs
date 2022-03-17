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
        [Range(0, int.MaxValue, ErrorMessage = "Chapter count cannot be less than 0!")]
        public int ChapterCount { get; set; }
        public string Summary { get; set; }

        [ForeignKey("MangakaID")]
        public int MangakaID { get; set; }
        public Mangaka Mangaka { get; set; }
    }
}
