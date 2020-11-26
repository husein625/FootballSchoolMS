using FotballSchoolMS.DAL.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballSchoolMS.Models
{
    public class PlayerMembershipFee : BaseEntity
    {
        

        [Required(ErrorMessage = "Type in please")]
        public DateTime Date { get; set; }

        //foreign key from player model
        public int PlayerID { get; set; }
        public Player Player { get; set; }

        //foreign key from membership fee model
        public int MembershipFeeID { get; set; }
        public MembershipFee MembershipFee { get; set; }
    }
}
