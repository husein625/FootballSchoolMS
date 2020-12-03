using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Repository
{
   public class TrainingRepository : GenericRepository<Training>, ITrainingRepository
    {
        public TrainingRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
