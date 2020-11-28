using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
   public class SeasonViewModel
    {
        public SeasonViewModel(List<Season> seasons)
        {
            Collection = seasons.Select(season => new SeasonDto(season)).ToList();
        }
        public List<SeasonDto> Collection { get; set; }

    }
}
