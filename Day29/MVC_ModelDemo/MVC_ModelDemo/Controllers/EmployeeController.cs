using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_ModelDemo.Models;
namespace MVC_ModelDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public EmployeeBusinessLayer obj = new EmployeeBusinessLayer();
        public ActionResult Index()
        {
           
            List<Employee> data = obj.GetEmployeeDetails(1);
            return View(data);
        }

        public ActionResult Create()
        {
            var data = Request.Form;
            obj.CreateEmploye(2, data["Name"], data["Address"], data["City"], data["Email"]);
            Employee employee = new Employee();
            return View(employee);
        }

        public ActionResult Sample(int id)
        {
            var data = obj.GetEmployeeDetails(id);
            ViewData["model"] = data;
            return View();
        }
    }
}