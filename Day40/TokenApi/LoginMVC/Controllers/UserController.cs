using LoginMVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LoginMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        
        public ActionResult Index()
        {
            
            return View();
        }

        
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(ViewModel user)
        {
            string url = "https://localhost:44347/token";
            
            using (WebClient web = new WebClient())
            {
                web.Headers.Add("Accept:application/json");
                web.Headers.Add("Content-type:application/x-www-form-urlencoded");
                var data = JsonConvert.SerializeObject(user).ToString();
                var resp  = web.UploadString(url,"Post",data);
                var token = JsonConvert.DeserializeObject(resp);
                Response.Write(token);
            }
            return View("Login");
        }


    }
}