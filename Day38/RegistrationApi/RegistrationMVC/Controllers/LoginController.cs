using Newtonsoft.Json;
using RegistrationApi.Models;
using RegistrationApi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace RegistrationMVC.Controllers
{
    public class LoginController : Controller
    {
        public RegistrationEntities db = new RegistrationEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginUser(LoginModel user)
        {
            if (ModelState.IsValid)
            {
                string url = "https://localhost:44373/LoginUser";
                string response;
                using (WebClient web = new WebClient())
                {
                    web.Headers.Add("Accept:application/json");
                    web.Headers.Add("Content-type:application/json");
                    var data = JsonConvert.SerializeObject(user);
                    response = web.UploadString(url, "Post", data);
                }

                if (response.Contains("Done"))
                {
                    return View("ViewUser",db.Registers.FirstOrDefault(s=>s.Username==user.UserName));
                }
                else
                {
                    ViewBag.UserMessage = "Check Username and Password";
                    return View();
                }
            }
            return View();
           
        }

        public ActionResult ViewUser()
        {

            return View();
        }
    }
}