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
    public class CompetitionTypeController : Controller
    {
        private ICompetitionTypeRepository _competitionTypeRepository;
        public CompetitionTypeController(ICompetitionTypeRepository competitionTypeRepository)
        {
            _competitionTypeRepository = competitionTypeRepository;
        }
        [HttpGet]
        public IEnumerable<CompetitionType> Get()
        {
            return _competitionTypeRepository.GetAll();
        }

        [HttpGet]
        public CompetitionType GetCompetitionTypeByID(int competitionTypeId)
        {
            return _competitionTypeRepository.GEtById(competitionTypeId);
        }

        [HttpPost]
        public void SaveCompetitionType([FromBody] CompetitionType competitionType)
        {
            _competitionTypeRepository.Insert(competitionType);
        }

        [HttpDelete]
        public void DeleteCompetitionType(int competitionTypeId)
        {
            _competitionTypeRepository.Delete(competitionTypeId);
        }

        [HttpPut]
        public void UpdateCompetitionType(CompetitionType competitionType, int competitionTypeId)
        {
            _competitionTypeRepository.Update(competitionType, competitionTypeId);
        }
    }
}
