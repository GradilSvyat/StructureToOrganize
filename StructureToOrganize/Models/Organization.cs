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
        [Required]
        public string Name { get; set; }
        [Key]
        public int Code { get; set; }
        [Required]
        public string Owner { get; set; }
        public string GetOrganizationType (byte key)
        {
            return organizationType[key];
        }
        public List<string> GetAllOrganizationType ()
        {
            List<string> result = new List<string>();
            foreach(KeyValuePair<byte, string> keyValuePair in organizationType)
            {
                result.Add(keyValuePair.Value);
            }
            return result;
        }
        private Dictionary<byte, string> organizationType = new Dictionary<byte, string>()
        {
            { 0, "General Partnership"},
            { 1, "Limited partnerships"},
            { 2, "Limited Liability Company (Co.Ltd.)"},
            { 3, "Incorporated company"},
            { 4, "Social enterprise"},
            { 5, "Other"}
        };
    }
}
