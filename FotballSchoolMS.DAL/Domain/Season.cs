using FotballSchoolMS.DAL.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FS20.Models
{
    public class Season : BaseEntity
    {
        

        [Required(ErrorMessage = "Please enter the season")]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }


        public DateTime DateFrom { get; set; }

        [Display(Name = "Date to")]
        public DateTimeOffset? DateTo { get; set; }

        public List<Competition> Competitions { get; set; }

    }
}
