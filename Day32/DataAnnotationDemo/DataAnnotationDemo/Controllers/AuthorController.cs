using DataAnnotationDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataAnnotationDemo.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Create(Author auth)
        {
            if (ModelState.IsValid)
            {
                var db = new AuthorContext();
                db.Authors.Add(auth);
                db.SaveChanges();
            }
        }
    }
}