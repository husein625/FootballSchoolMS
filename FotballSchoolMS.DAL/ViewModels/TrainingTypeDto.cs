using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
   public class TrainingTypeDto
    {
        public TrainingTypeDto()
        {

        }
        public TrainingTypeDto(TrainingType trainingType)
        {
            Id = trainingType.Id;
            Name = trainingType.Name;

        }
        public int Id { get; set; }
        public String Name { get; set; }
    }
}
