using FotballSchoolMS.DAL.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballSchoolMS.Models
{
    public class MembershipFee : BaseEntity
    {
        

        [Required(ErrorMessage = "Please enter the name")]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }

        public decimal? Amount { get; set; }

        public virtual ICollection<PlayerMembershipFee> PlayerMembershipFees { get; set; }
    }
}
