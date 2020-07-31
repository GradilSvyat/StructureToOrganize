using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StructureToOrganize.Models
{
    public class Organization
    {
        public Organization()
        {
            Countries = new List<Country>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Code { get; set; }
        [Required]
        public string Owner { get; set; }
        public string OrganizationType
        {
            get 
            {
                return organizationType;
            }
            set
            {
                if (allOrganizationType.Contains(value))
                    organizationType = value;
            }
        }
        public ICollection<Country> Countries { get; set; }

        private string organizationType;
        public static List<string> GetAllOrganizationType ()
        {
            return allOrganizationType;
        }
        private static readonly List <string> allOrganizationType = new List <string>()
        {
            "General Partnership",
            "Limited partnerships",
            "Limited Liability Company (Co.Ltd.)",
            "Incorporated company",
            "Social enterprise",
            "Other"
        };
    }
}
