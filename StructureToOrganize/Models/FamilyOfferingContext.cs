using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructureToOrganize.Models
{
    public class FamilyOfferingContext: DbContext
    {
        public DbSet<Offering> Offerings { get; set; }
        public DbSet<Family> Families { get; set; }
    }
}
