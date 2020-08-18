using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StructureToOrganize.Models;

namespace StructureToOrganize
{
    internal class AuthenticationDBContext : IdentityDbContext<IdentityUser>
    {
        public AuthenticationDBContext ()
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Authentication_db;Trusted_Connection=True;");
        }
    }
}