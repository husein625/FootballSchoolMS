using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Repository
{
   public class PlayerMembershipFeeRepository : GenericRepository<PlayerMembershipFee>, IPlayerMembershipFeeRepository
    {
        public PlayerMembershipFeeRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
