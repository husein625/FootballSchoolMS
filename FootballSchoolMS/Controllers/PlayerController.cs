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
    public class PlayerController : Controller
    {
        private IPlayerRepository _playerRepository;
        public PlayerController(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }
        [HttpGet]
        public IEnumerable<Player> Get()
        {
            return _playerRepository.GetAll();
        }

        [HttpGet]
        public Player GetPlayerByID(int playerId)
        {
            return _playerRepository.GEtById(playerId);
        }

        [HttpPost]
        public  void SavePlayer([FromBody] Player player) 
        {
             _playerRepository.Insert(player);
        }

        [HttpDelete]
        public void DeletePlayer(int playerId)
        {
            _playerRepository.Delete(playerId);
        }

        [HttpPut]
        public void UpdatePlayer(Player player, int playerId)
        {
            _playerRepository.Update(player, playerId);
        }
    }
}
