using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
   public class CompetitionDto
    {
        public CompetitionDto()
        {

        }

        public CompetitionDto(Competition competition)
        {
            Id = competition.Id;
            Name = competition.Name;
            IsActive = competition.IsActive;
            CompetitionTypeID = competition.CompetitionTypeID;
            SeasonID = competition.SeasonID;
        }

        public int Id { get; set; }
        public String Name { get; set; }
        public bool? IsActive { get; set; }
        public int? CompetitionTypeID { get; set; }
        public int? SeasonID { get; set; }
    }
}
