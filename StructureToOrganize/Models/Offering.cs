using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StructureToOrganize.Models
{
    public class Offering
    {
        public Offering()
        {
            Departments = new List<Department>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("Family")]
        public int? FamilyId { get; set; }
        public Family Family { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
