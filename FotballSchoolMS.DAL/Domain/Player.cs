using FotballSchoolMS.DAL.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FootballSchoolMS.Models
{
    public class Player : BaseEntity
    {
        

        [Required(ErrorMessage = "Please enter the name of the player")]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Please enter the Last name of the player")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter the uniqueId")]
        [Display(Name = "Unique ID")]
        public int UniqueId { get; set; }

        [Required(ErrorMessage = "Please enter the Birth date")]
        public DateTimeOffset BirthDate { get; set; }

        [Required(ErrorMessage = "Please enter the mother name")]
        [Display(Name = "Mother name")]
        [StringLength(50)]
        public string MotherName { get; set; }

        [Required(ErrorMessage = "Please enter the mother telephone")]
        [Display(Name = "Mother telephone")]
        public int MotherTelephone { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
    ErrorMessage = "The email address is not entered in a correct format")]
        public string MotherEmail { get; set; }

        [Required(ErrorMessage = "Please enter the father name")]
        [Display(Name = "Father name")]
        [StringLength(50)]
        public string FatherName { get; set; }

        [Required(ErrorMessage = "Please enter the father telephone")]
        [Display(Name = "Father telephone")]
        public int FatherTelephone { get; set; }


        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
    ErrorMessage = "The email address is not entered in a correct format")]
        public string FatherEmail { get; set; }

        [Required(ErrorMessage = "Please enter the registration number")]
        [Display(Name = "Registration number")]
        public int RegistrationNumber { get; set; }

        public DateTime DateFrom { get; set; }

        [Display(Name = "Date to")]
        public DateTimeOffset? DateTo { get; set; }


        public int GroupID { get; set; }
        public Group Group { get; set; }

        public string AspNetUserID { get; set; }
        [ForeignKey("AspNetUserID")]
        public virtual ApplicationUser User { get; set; }

    }
}
