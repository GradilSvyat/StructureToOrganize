using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StructureToOrganize.Models
{
    public class Business
    {
        [Key]
        public string Name { get; set; }
    }
}
