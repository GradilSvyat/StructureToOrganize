using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructureToOrganize.Models
{
    public class CountryBusinessContext: DbContext
    {
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
