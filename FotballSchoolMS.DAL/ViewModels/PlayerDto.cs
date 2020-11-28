using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
   public class PlayerDto
    {
        public PlayerDto()
        {

        }
        public PlayerDto(Player player)
        {
            Id = player.Id;
            Name = player.Name;
            LastName = player.LastName;
            UniqueID = player.UniqueId;
            BirthDate = player.BirthDate;
            Telephone = player.Telephone;
            Email = player.Email;
            DateTo = player.DateTo;
            GroupID = player.GroupID;
        }
        public int Id { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public int UniqueID { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public int Telephone { get; set; }
        public String Email { get; set; }
        public DateTimeOffset? DateTo { get; set; }
        public int GroupID { get; set; }

    }
}
