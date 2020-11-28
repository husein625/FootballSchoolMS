using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
  public  class PlayerMembershipFeeViewModel
    {
        public PlayerMembershipFeeViewModel(List<PlayerMembershipFee> playerMembershipFees)
        {
            Collection = playerMembershipFees.Select(playerMembershipFee => new PlayerMembershipFeeDto(playerMembershipFee)).ToList();
        }
        public List<PlayerMembershipFeeDto> Collection { get; set; }
    }
}
