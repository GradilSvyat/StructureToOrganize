using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructureToOrganize.Models
{
    public class OfferingDepartmentContext: DbContext
    {
        public DbSet<Offering> Offerings { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
