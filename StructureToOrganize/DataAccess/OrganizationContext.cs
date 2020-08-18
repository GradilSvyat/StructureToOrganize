using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace StructureToOrganize.Models
{
    public class OrganizationContext: DbContext
    {
        public OrganizationContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Offering> Offerings { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StructureToOrganize_db;Trusted_Connection=True;");
        }
    }
}
