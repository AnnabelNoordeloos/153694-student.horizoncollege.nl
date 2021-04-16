using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Smoothboard.Models;

namespace Smoothboard.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacten { get; set;  }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Filiaal> Filiaalen { get; set; }
        public DbSet<Gebruiker> Gebruikers { get; set; }
        public DbSet<Interesse> Interesses { get; set; }
        public DbSet<Materiaal> Materialen { get; set; }
        public DbSet<Surfboards> Surfboards { get; set; }
        public DbSet<Voorraad> Voorraaden { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Voorraad>()
                .HasKey(v => new { v.SurfboardId, v.FiliaalId });

            builder.Entity<Voorraad>()
                .HasOne(v => v.Surfboard)
                .WithMany(s => s.Voorraad)
                .HasForeignKey(v => v.SurfboardId);

            builder.Entity<Voorraad>()
                .HasOne(v => v.Filiaal)
                .WithMany(f => f.Voorraad)
                .HasForeignKey(v => v.FiliaalId);
        }
    }
}
