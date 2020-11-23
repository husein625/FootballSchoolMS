using FotballSchoolMS.DAL.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FS20.Models
{
    public class Opponent : BaseEntity
    {
        

        [Required(ErrorMessage = "Please enter the opponent")]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }
        public bool? IsActive { get; set; }
    }
}
