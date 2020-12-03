using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Repository
{
  public  class PlayerRepository : GenericRepository<Player> , IPlayerRepository
    {
        public PlayerRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }

    }
}
