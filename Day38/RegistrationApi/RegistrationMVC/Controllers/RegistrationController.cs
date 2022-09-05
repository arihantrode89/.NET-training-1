using Newtonsoft.Json;
using RegistrationApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace RegistrationMVC.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(Register user)
        {
            if (ModelState.IsValid)
            {
                string url = "https://localhost:44373/AddUser";
                using (WebClient web = new WebClient())
                {
                    web.Headers.Add("Accept:application/json");
                    web.Headers.Add("Content-type:application/json");
                    var data = JsonConvert.SerializeObject(user);
                    web.UploadString(url, "Post", data);
                }
                return RedirectToAction("LoginUser", "Login");
            }
            return View();
        }

    }
}