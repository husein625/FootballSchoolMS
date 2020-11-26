using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballSchoolMS.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Player> Players { get; set; }
    }
}
