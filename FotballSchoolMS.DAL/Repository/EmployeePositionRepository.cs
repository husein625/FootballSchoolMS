using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Repository
{
   public class EmployeePositionRepository : GenericRepository<EmployeePosition>, IEmployeePositionRepository
    {
        public EmployeePositionRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
                
        }
    }
}
