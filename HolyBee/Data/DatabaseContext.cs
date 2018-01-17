using HolyBee.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolyBee.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<MediaItem> MediaItem { get; set; }
        public DbSet<Gebruiker> Gebruikers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MediaItem>().ToTable("MediaItem");
            modelBuilder.Entity<Gebruiker>().ToTable("Gebruiker");
        }
    }
}
