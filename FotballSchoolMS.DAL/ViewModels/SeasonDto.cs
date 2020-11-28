using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
   public class SeasonDto
    {
        public SeasonDto()
        {

        }
        public SeasonDto(Season season)
        {
            Id = season.Id;
            Name = season.Name;
            DateTo = season.DateTo;
        }
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTimeOffset? DateTo { get; set; }
    }
}
