using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
    public class StadiumViewModel
    {
        public StadiumViewModel(List<Stadium> stadiums)
        {
            Collection = stadiums.Select(stadium => new StadiumDto(stadium)).ToList();
        }
        public List<StadiumDto> Collection { get; set; }
    }
}
