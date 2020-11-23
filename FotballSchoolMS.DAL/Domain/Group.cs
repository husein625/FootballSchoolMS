using FotballSchoolMS.DAL.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FS20.Models
{
    public class Group : BaseEntity
    {
        

        [Required(ErrorMessage = "Please enter the name of the group")]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "Age")]
        public int? Age { get; set; }

        public int NumberOfPlayers { get; set; }

        [Required(ErrorMessage = "Please enter the date")]
        [Display(Name = "Date from")]
        public DateTime DateFrom { get; set; }

        [Display(Name = "Date to")]
        public DateTime? DateTo { get; set; }

        public int? CoachID { get; set; }
        public int? AssistantCoach1ID { get; set; }
        public int? AssistantCoach2ID { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Employee Employee1 { get; set; }
        public virtual Employee Employee2 { get; set; }
    }
}
