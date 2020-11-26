using FotballSchoolMS.DAL.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballSchoolMS.Models
{
    public class Stadium : BaseEntity
    {


        [Required(ErrorMessage = "Please enter the name of stadium")]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the place")]
        [Display(Name = "Place")]
        [StringLength(50)]
        public string Place { get; set; }

        [Required(ErrorMessage = "Please enter the address")]
        [Display(Name = "Address")]
        [StringLength(50)]
        public string Address { get; set; }
        public int Telephone { get; set; }


        [Required(ErrorMessage = "Please enter the description")]
        [Display(Name = "Description")]
        [StringLength(500)]
        public string Description { get; set; }
    }
}
