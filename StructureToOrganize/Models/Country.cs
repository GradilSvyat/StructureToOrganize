﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StructureToOrganize.Models
{
    public class Country
    {
        public string Name { get; set; }
        [Key]
        public int Code { get; set; }
    }
}