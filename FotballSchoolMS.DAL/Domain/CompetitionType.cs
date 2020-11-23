using FotballSchoolMS.DAL.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FS20.Models
{
    public class CompetitionType : BaseEntity
    {

    
        [Required]
        [StringLength(50)]
        public string Name { get; set; }


        public List<Competition> Competitions { get; set; }
    }
}
