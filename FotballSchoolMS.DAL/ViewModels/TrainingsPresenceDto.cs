using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
  public  class TrainingsPresenceDto
    {
        public TrainingsPresenceDto()
        {

        }
        public TrainingsPresenceDto(TrainingsPresence trainingsPresence)
        {
            Id = trainingsPresence.Id;
            IsActive = trainingsPresence.IsActive;
            PlayerID = trainingsPresence.PlayerID;
            CoachID = trainingsPresence.CoachID;
            TrainingID = trainingsPresence.TrainingID;
        }
        public int Id { get; set; }
        public bool? IsActive { get; set; }
        public int? PlayerID { get; set; }
        public int? CoachID { get; set; }
        public int TrainingID { get; set; }
    }
}
