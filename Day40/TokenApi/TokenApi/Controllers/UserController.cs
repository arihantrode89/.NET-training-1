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
    }
}
