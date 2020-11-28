using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
  public  class PlayerMembershipFeeDto
    {
        public PlayerMembershipFeeDto()
        {

        }
        public PlayerMembershipFeeDto(PlayerMembershipFee playerMembershipFee)
        {
            Id = playerMembershipFee.Id;
            PlayerID = playerMembershipFee.PlayerID;
            MembershipFeeID = playerMembershipFee.MembershipFeeID;
        }
        public int Id { get; set; }
        public int PlayerID { get; set; }
        public int MembershipFeeID { get; set; }
    }
}
