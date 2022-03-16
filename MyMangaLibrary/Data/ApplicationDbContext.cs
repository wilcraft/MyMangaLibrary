using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MyMangaLibrary.Models;

namespace MyMangaLibrary.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MyMangaLibrary.Models.Manga> Manga { get; set; }
        public DbSet<MyMangaLibrary.Models.Mangaka> Mangaka { get; set; }
    }
}
