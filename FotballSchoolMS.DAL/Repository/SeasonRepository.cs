using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Repository
{
    public class SeasonRepository : GenericRepository<Season>, ISeasonRepository
    {
        public SeasonRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
