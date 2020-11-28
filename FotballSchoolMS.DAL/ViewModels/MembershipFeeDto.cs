using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
   public class MembershipFeeDto
    {
        public MembershipFeeDto()
        {

        }
        public MembershipFeeDto(MembershipFee membershipFee)
        {
            Id = membershipFee.Id;
            Name = membershipFee.Name;
            Amount = membershipFee.Amount;
        }
        public int Id { get; set; }
        public String Name { get; set; }
        public decimal? Amount { get; set; }

    }
}
