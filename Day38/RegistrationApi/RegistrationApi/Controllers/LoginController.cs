using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RegistrationApi.Models;
using RegistrationApi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RegistrationApi.Controllers
{
    public class LoginController : ApiController
    {

        public RegistrationEntities db = new RegistrationEntities();
        [HttpPost]
        [Route("LoginUser")]
        public IHttpActionResult UserLogin([FromBody] JToken user)
        {
            try
            {
                var data = JsonConvert.DeserializeObject<LoginModel>(user.ToString());
                var userdata = db.Registers.FirstOrDefault(s => s.Username == data.UserName);
                if(userdata == null)
                {
                    return Ok("Not exist");
                }
                else
                {
                    if((data.UserName == userdata.Username) && (data.Password == userdata.Password))
                    {
                        return Ok("Done");
                    }
                    else
                    {
                        return Ok("Not");
                    }
                }
                
            }
            catch
            {
                return Ok("Not exist");
            }
        }
    }
}
