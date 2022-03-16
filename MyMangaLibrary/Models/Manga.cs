using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMangaLibrary.Models
{
    public class Manga
    {
        public int ID { get; set; }
        public decimal Rating { get; set; }
        public string Name { get; set; }
        public int ChapterCount { get; set; }
    }
}
