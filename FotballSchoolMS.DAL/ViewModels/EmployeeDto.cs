using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
   public class EmployeeDto
    {
        public EmployeeDto()
        {

        }

        public EmployeeDto(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            LastName = employee.LastName;
            Email = employee.Email;
            Telephone = employee.Telephone;
            EmployeePositionID = employee.EmployeePositionID;
        }
        public int Id { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public int Telephone { get; set; }
        public int EmployeePositionID { get; set; }

    }
}
