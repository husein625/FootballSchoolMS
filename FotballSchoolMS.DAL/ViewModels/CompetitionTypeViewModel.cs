using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
    public class CompetitionTypeViewModel
    {
        public CompetitionTypeViewModel(List<CompetitionType> competitionTypes)
        {
            Collection = competitionTypes.Select(competitionType => new CompetitionTypeDto(competitionType)).ToList();
        }
        public List<CompetitionTypeDto> Collection { get; set; }
    }
}
