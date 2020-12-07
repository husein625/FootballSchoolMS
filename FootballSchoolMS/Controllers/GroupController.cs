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
    public class GroupController : Controller
    {
        private IGroupRepository _groupRepository;
        public GroupController(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }
        [HttpGet]
        public IEnumerable<Group> Get()
        {
            return _groupRepository.GetAll();
        }

        [HttpGet]
        public Group GetGroupByID(int groupId)
        {
            return _groupRepository.GEtById(groupId);
        }

        [HttpPost]
        public void SaveGroup([FromBody] Group groupId)
        {
            _groupRepository.Insert(groupId);
        }

        [HttpDelete]
        public void DeleteGroup(int groupId)
        {
            _groupRepository.Delete(groupId);
        }

        [HttpPut]
        public void UpdateGroup(Group group, int groupId)
        {
            _groupRepository.Update(group, groupId);
        }
    }
}
