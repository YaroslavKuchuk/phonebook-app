using Phonebook.BusinessLogic.Services;
using Phonebook.Models.DataModels;
using System.Web.Http;

namespace Phonebook.API.Controllers
{
    public class GroupsController : ApiController
    {
        public readonly IGroupService _groupService;

        public GroupsController()
        {
            _groupService = new GroupService();
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var groups = _groupService.GetList();

            return Ok(groups);
        }


        [HttpPost]
        public IHttpActionResult Add([FromBody]Group group)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _groupService.Add(group);

            return Ok();
        }
    }
}
