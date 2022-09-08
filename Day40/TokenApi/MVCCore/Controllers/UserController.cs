using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MVCCore.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

       
       
    }
}
