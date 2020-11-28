using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FotballSchoolMS.DAL.ViewModels
{
    public class EmployeePositionViewModel
    {
        public EmployeePositionViewModel(List<EmployeePosition> employeePositions)
        {
            Collection = employeePositions.Select(employee => new EmployeePositionDto(employee)).ToList();
        }
        public List<EmployeePositionDto> Collection { get; set; }
    }
}
