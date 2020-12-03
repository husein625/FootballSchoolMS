using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Repository
{
   public class StadiumRepository : GenericRepository<Stadium>, IStadiumRepository
    {
        public StadiumRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
