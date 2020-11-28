using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
   public class TrainingsPresenceViewModel
    {
        public TrainingsPresenceViewModel(List<TrainingsPresence>trainingsPresences)
        {
            Collection = trainingsPresences.Select(trainingsPresence => new TrainingsPresenceDto(trainingsPresence)).ToList();
        }
        public List<TrainingsPresenceDto> Collection { get; set; }
    }
}
