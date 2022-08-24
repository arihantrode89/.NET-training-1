using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempData_DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TempData["Message"] = "Hello";
            //var status = new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            //return status;
            return View();
        }

        public ActionResult About()
        {
            var abc = TempData["Message"];
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}