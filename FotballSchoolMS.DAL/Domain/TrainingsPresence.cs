using FotballSchoolMS.DAL.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballSchoolMS.Models
{
    public class TrainingsPresence : BaseEntity
    {

        

       
        public bool? IsActive { get; set; }

        public int? PlayerID { get; set; }
        public Player Player { get; set; }

        public int? CoachID { get; set; }
        public Employee Employee { get; set; }

        public int TrainingID { get; set; }
        public Training Training { get; set; }
    }
}
