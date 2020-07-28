using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StructureToOrganize.Models
{
    public class Family
    {
        public Family()
        {
            Offerings = new List<Offering>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? BusinessId { get; set; }
        public Business Business { get; set; }
        public ICollection<Offering> Offerings { get; set; }
    }
}
