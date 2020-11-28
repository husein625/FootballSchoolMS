using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
   public class OpponentViewModel
    {
        public OpponentViewModel(List<Opponent> opponents)
        {
            Collection = opponents.Select(opponent => new OpponentDto(opponent)).ToList();
        }
        public List<OpponentDto> Collection { get; set; }
    }
}
