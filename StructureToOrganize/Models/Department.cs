using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StructureToOrganize.Models
{
    public class Department
    {
        //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public string Name { get; set; }
        [ForeignKey("Offering")]
        public int? OfferingId { get; set; }
        public Offering Offering { get; set; }
    }
}
