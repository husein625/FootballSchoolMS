using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
    public class StadiumDto
    {
        public StadiumDto()
        {

        }
        public StadiumDto(Stadium  stadium)
        {
            Id = stadium.Id;
            Name = stadium.Name;
            Address = stadium.Address;
            Capacity = stadium.Capacity;
            Telephone = stadium.Telephone;
        }
        public int Id { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public int Capacity { get; set; }
        public int Telephone { get; set; }
    }
}
