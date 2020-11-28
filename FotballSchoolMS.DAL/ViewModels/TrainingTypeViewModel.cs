using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
  public  class TrainingTypeViewModel
    {
        public TrainingTypeViewModel(List<TrainingType> trainingTypes)
        {
            Collection = trainingTypes.Select(trainingType => new TrainingTypeDto(trainingType)).ToList();
        }
        public List<TrainingTypeDto> Collection { get; set; }
    }
}
