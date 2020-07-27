using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StructureToOrganize.Models
{
    public class Family
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Name { get; set; }
    }
}
