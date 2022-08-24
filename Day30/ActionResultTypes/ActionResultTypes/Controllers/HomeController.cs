using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultTypes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Content()
        {
            return Content("<h6>Hi arihant</h6>", "text/html", System.Text.Encoding.UTF8);
        }

        public ActionResult File()
        {
            return File("C:/Users/arihant.rode/Downloads/Bangalore.pdf", "application/pdf", "HolidayList.pdf");
        }

        public ActionResult RedirectResult()
        {
            return Redirect("https://google.com");
        }

        public ActionResult Status()
        {

            var status = new HttpStatusCodeResult(200);
            return status;
        }
    }
}