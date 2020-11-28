using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
   public class EmployeeViewModel
    {
        public EmployeeViewModel(List<Employee> employees)
        {
            Collection = employees.Select(employee => new EmployeeDto(employee)).ToList();
        }
        public List<EmployeeDto> Collection { get; set; }
    }
}
