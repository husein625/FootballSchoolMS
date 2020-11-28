using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
  public  class CompetitionViewModel
    {
        public CompetitionViewModel(List<Competition> competitions)
        {
            Collection = competitions.Select(competition => new CompetitionDto(competition)).ToList();
        }
        public List<CompetitionDto> Collection { get; set; }
    }
}
