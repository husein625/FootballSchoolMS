using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
  public  class TrainingDto
    {
        public TrainingDto()
        {

        }
        public TrainingDto(Training training)
        {
            Id = training.Id;
            Name = training.Name;
            GroupID = training.GroupID;
            TrainingTypeID = training.TrainingTypeID;
        }
        public int Id { get; set; }
        public String Name { get; set; }
        public int? GroupID { get; set; }
        public int? TrainingTypeID { get; set; }
    }

}
