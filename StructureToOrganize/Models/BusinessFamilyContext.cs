using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructureToOrganize.Models
{
    public class BusinessFamilyContext: DbContext
    {
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Family> Families { get; set; }
    }
}
