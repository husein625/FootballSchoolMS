using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Repository
{
   public class TrainingsPresenceRepository : GenericRepository<TrainingsPresence>, ITrainingPresenceRepository
    {
        public TrainingsPresenceRepository(ApplicationDbContext  applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
