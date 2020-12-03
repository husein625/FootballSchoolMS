using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Repository
{
   public class MembershipFeeRepository : GenericRepository<MembershipFee>, IMembershipFeeRepository
    {
        public MembershipFeeRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
