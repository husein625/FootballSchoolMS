using FootballSchoolMS.Models;
using FotballSchoolMS.DAL.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballSchoolMS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employeeRepository.GetAll();
        }

        [HttpGet]
        public Employee GetEmployeeByID(int employeeId)
        {
            return _employeeRepository.GEtById(employeeId);
        }

        [HttpPost]
        public void SaveEmployee([FromBody] Employee employee)
        {
            _employeeRepository.Insert(employee);
        }

        [HttpDelete]
        public void DeleteEmployee(int employeeId)
        {
            _employeeRepository.Delete(employeeId);
        }

        [HttpPut]
        public void UpdateEmployee(Employee employee, int employeeId)
        {
            _employeeRepository.Update(employee, employeeId);
        }
    }
}
