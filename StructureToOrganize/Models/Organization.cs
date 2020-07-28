﻿using System;
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
        private string organizationType;
        public List<string> GetAllOrganizationType ()
        {
            return allOrganizationType;
        }
        private static List <string> allOrganizationType = new List <string>()
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