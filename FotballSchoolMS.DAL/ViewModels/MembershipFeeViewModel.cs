using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
   public class MembershipFeeViewModel
    {
        public MembershipFeeViewModel(List<MembershipFee> membershipFees)
        {
            Collection = membershipFees.Select(membershipFee => new MembershipFeeDto(membershipFee)).ToList();
        }
        public List<MembershipFeeDto> Collection { get; set; }
    }
}
