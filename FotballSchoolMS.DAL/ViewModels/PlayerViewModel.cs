using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
   public class PlayerViewModel
    {
        public PlayerViewModel(List<Player> players)
        {
            Collection = players.Select(player => new PlayerDto(player)).ToList();
        }
        public List<PlayerDto> Collection { get; set; }
    }
}
