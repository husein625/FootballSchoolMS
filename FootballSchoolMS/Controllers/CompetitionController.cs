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
    public class CompetitionController : Controller
    {
        private ICompetitionRepository _competitionRepository;
        public CompetitionController(ICompetitionRepository competitionRepository)
        {
            _competitionRepository = competitionRepository;
        }
        [HttpGet]
        public IEnumerable<Competition> Get()
        {
            return _competitionRepository.GetAll();
        }

        [HttpGet]
        public Competition GetCompetitionByID(int competitionId)
        {
            return _competitionRepository.GEtById(competitionId);
        }

        [HttpPost]
        public void SaveCompetition([FromBody] Competition competition)
        {
            _competitionRepository.Insert(competition);
        }

        [HttpDelete]
        public void DeleteCompetition(int competitionId)
        {
            _competitionRepository.Delete(competitionId);
        }

        [HttpPut]
        public void UpdateCompetition(Competition competition, int competitionId)
        {
            _competitionRepository.Update(competition, competitionId);
        }
    }
}
