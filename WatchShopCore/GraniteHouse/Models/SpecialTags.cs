﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GraniteHouse.Models
{
    public class SpecialTags
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "SpecialTags Name")]
        public string Name { get; set; }
    }
}
