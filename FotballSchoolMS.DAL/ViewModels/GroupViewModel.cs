using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
   public class GroupViewModel
    {
        public GroupViewModel(List<Group> groups )
        {
            Collection = groups.Select(group => new GroupDto(group)).ToList();
        }
        public List<GroupDto> Collection { get; set; }
    }
}
