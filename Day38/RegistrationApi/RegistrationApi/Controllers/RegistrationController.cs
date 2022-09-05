using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RegistrationApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RegistrationApi.Controllers
{
    public class RegistrationController : ApiController
    {
        public RegistrationEntities db = new RegistrationEntities();

        [HttpPost]
        [Route("AddUser")]
        public IHttpActionResult AddUser([FromBody] JToken user)
        {
            try
            {
                var data = JsonConvert.DeserializeObject<Register>(user.ToString());
                db.Registers.Add(data);
                db.SaveChanges();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        
    }
}
