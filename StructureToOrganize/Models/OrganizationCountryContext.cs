using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructureToOrganize.Models
{
    public class OrganizationCountryContext: DbContext
    {
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
