using LoginMVC.Filters;
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
    public class AdminController : Controller
    {
        // GET: User

        [AuthorizationFilter]
        public ActionResult Index()
        {
            return View();
        }



    }
}