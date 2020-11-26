﻿using FotballSchoolMS.DAL.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballSchoolMS.Models
{
    public class TrainingType : BaseEntity
    {
        
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
