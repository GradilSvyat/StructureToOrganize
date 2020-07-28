using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StructureToOrganize.Models
{
    public class Country
    {
        public Country()
        {
            Businesses = new List<Business>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public int? OrganizationCode { get; set; }
        public Organization Organization { get; set; }
        public ICollection<Business> Businesses { get; set; }
    }
}
