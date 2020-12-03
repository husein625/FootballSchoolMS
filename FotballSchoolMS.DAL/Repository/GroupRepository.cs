using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Repository
{
   public class GroupRepository : GenericRepository<Group> , IGroupRepository
    {
        public GroupRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
