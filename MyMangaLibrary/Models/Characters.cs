using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyMangaLibrary.Models
{
    public class Characters
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [ForeignKey("MangaID")]
        public int MangaID { get; set; }
        public Manga MangaName { get; set; }
    }
}
