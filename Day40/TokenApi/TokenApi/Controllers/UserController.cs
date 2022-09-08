using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TokenApi.Models;

namespace TokenApi.Controllers
{
    public class UserController : ApiController
    {
        ForumSiteEntities db = new ForumSiteEntities();


        [Authorize(Roles ="Admin")]
        [Route("Admin")]
        [HttpGet]
        public UserManagement Admin()
        {
            var user = User.Identity;
            return db.UserManagements.FirstOrDefault(s => s.UserName == user.Name);
        }

        [Authorize(Roles = "Admin")]
        [Route("Student")]
        [HttpGet]
        public UserManagement Student()
        {
            var user = User.Identity;
            return db.UserManagements.FirstOrDefault(s => s.UserName == user.Name);
        }

        [Route("GetDetails")]
        [HttpGet]
        public UserManagement GetUserDetails()
        {
            var user = User.Identity;
            return db.UserManagements.FirstOrDefault(s => s.UserName == user.Name);
        }

        [Route("Gett")]
        [HttpPost]
        public UserManagement ABc([FromBody] JToken ee)
        {
            var user = User.Identity;
            var data = JsonConvert.DeserializeObject<model>(ee.ToString());
            return db.UserManagements.FirstOrDefault(s => s.UserName == data.username && s.Password == data.password);
        }
    }
    public class model
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
