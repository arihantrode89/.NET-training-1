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
            //var data = Request.Form;
            //obj.CreateEmploye(2, Name,Address, City, Email);
            Employee employee = new Employee();
            return View(employee);
        }

        [HttpPost]
        public ActionResult Create(string Name, string Address, string City, string Email)
        {

            List<Employee> data = obj.GetEmployeeDetails(1);
            obj.CreateEmploye(2, Name, Address, City, Email);
            return View("Index",data);
            
        }
        public ActionResult Sample(int id)
        {
            var data = obj.GetEmployeeDetails(id);
            //ViewData["model"] = data;
            ViewBag.model = data;
            return View();
        }
    }
}