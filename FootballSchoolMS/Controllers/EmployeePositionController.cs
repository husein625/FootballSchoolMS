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
    public class EmployeePositionController : Controller
    {
        private IEmployeePositionRepository _employeePositionRepository;
        public EmployeePositionController(IEmployeePositionRepository employeePositionRepository)
        {
            _employeePositionRepository = employeePositionRepository;
        }
        [HttpGet]
        public IEnumerable<EmployeePosition> Get()
        {
            return _employeePositionRepository.GetAll();
        }

        [HttpGet]
        public EmployeePosition GetEmployeePositionByID(int employeePositionId)
        {
            return _employeePositionRepository.GEtById(employeePositionId);
        }

        [HttpPost]
        public void SaveEmployeePosition([FromBody] EmployeePosition employeePosition)
        {
            _employeePositionRepository.Insert(employeePosition);
        }

        [HttpDelete]
        public void DeleteEmployeePosition(int employeePositionId)
        {
            _employeePositionRepository.Delete(employeePositionId);
        }

        [HttpPut]
        public void UpdateEmployeePosition(EmployeePosition employeePosition, int employeePositionId)
        {
            _employeePositionRepository.Update(employeePosition, employeePositionId);
        }
    }
}
