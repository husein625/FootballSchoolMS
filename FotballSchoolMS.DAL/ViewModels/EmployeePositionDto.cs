using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
  public  class EmployeePositionDto
    {
        public EmployeePositionDto()
        {

        }
        public EmployeePositionDto(EmployeePosition employeePosition)
        {
            Id = employeePosition.Id;
            Name = employeePosition.Name;
        }

        public int Id { get; set; }
        public String Name { get; set; }
    }
}
