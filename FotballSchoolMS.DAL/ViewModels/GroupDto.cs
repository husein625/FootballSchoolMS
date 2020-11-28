using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
  public  class GroupDto
    {
        public GroupDto()
        {

        }
        public GroupDto(Group group)
        {
            Id = group.Id;
            Name = group.Name;
            Age = group.Age;
            NumberOfPlayers = group.NumberOfPlayers;
            DateTo = (DateTime)group.DateTo;
            CoachID = group.CoachID;
            AssistantCoach1ID = group.AssistantCoach1ID;
            AssistantCoach2ID = group.AssistantCoach2ID;

        }
        public int Id { get; set; }
        public String Name { get; set; }
        public int? Age { get; set; }
        public int NumberOfPlayers { get; set; }
        public DateTime DateTo { get; set; }
        public int? CoachID { get; set; }
        public int? AssistantCoach1ID { get; set; }
        public int? AssistantCoach2ID { get; set; }


    }
}
