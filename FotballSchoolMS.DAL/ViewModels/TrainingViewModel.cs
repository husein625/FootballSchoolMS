using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
  public  class TrainingViewModel
    {
        public TrainingViewModel(List<Training> trainings)
        {
            Collection = trainings.Select(training => new TrainingDto(training)).ToList();
        }
        public List<TrainingDto> Collection { get; set; }
    }
}
