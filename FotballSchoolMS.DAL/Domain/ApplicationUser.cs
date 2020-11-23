using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FS20.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Player> Players { get; set; }
    }
}
