using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ticketsystem.Models;
using Ticketsystem.Data.Migrations;

namespace Ticketsystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Progress> Progress { get; set; }
        public DbSet<AspNetUsers> AspNetUsers { get; set; }
        public DbSet<Applications> Applications { get; set; }
        public DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public DbSet<AspNetRoles> AspNetRoles { get; set; }

    }
}
