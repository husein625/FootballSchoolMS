using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
   public class OpponentDto
    {
        public OpponentDto()
        {

        }
        public OpponentDto(Opponent opponent)
        {
            Id = opponent.Id;
            Name = opponent.Name;
            IsActive = opponent.IsActive;
        }
        public int Id { get; set; }
        public String Name { get; set; }
        public bool? IsActive { get; set; }
    }
}
