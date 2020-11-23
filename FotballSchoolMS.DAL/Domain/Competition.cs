using FotballSchoolMS.DAL.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FS20.Models
{
    public class Competition : BaseEntity
    {
        

        [Required(ErrorMessage = "Please enter the competition")]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }

        public bool? IsActive { get; set; }

        public int? CompetitionTypeID { get; set; }
        public CompetitionType CompetitionType { get; set; }

        public int? SeasonID { get; set; }
        public Season Season { get; set; }
    }
}
