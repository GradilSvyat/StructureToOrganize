using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StructureToOrganize.Models
{
    public class Business
    {
        public Business()
        {
            Families = new List<Family>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("Country")]
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Family> Families { get; set; }
    }
}
