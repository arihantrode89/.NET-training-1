using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            //return "Welcome to Student Controller Page";
            return View();

        }

        public string About(string name,string id)
        {
            return $"Welcome {name} {id}";
            
        }

        
    }
}