using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
  public  class CompetitionTypeDto
    {
        public CompetitionTypeDto()
        {

        }
        public CompetitionTypeDto(CompetitionType competitionType )
        {
            Id = competitionType.Id;
            Name = competitionType.Name;
            
        }
        public int Id { get; set; }
        public String Name { get; set; }
    }
}
