using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Repository
{
   public class TrainingTypeRepository : GenericRepository<TrainingType>, ITrainingTypeRepository
    {
        public TrainingTypeRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
