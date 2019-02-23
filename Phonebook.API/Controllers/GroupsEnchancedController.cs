using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Phonebook.API.Controllers
{
    [RoutePrefix("api/new-controller")]
    public class GroupsEnchancedController : ApiController
    {
        [Route("action-route")]
        [HttpGet]
        public IHttpActionResult MyAction()
        {
            return Ok("my action");
        }
    }
}
