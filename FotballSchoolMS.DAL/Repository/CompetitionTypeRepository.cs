using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Repository
{
  public  class CompetitionTypeRepository : GenericRepository<CompetitionType>, ICompetitionTypeRepository
    {
        public CompetitionTypeRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
