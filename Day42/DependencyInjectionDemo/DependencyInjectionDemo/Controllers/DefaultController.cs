using DependencyInjectionDemo.Models;
using DependencyInjectionDemo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjectionDemo.Controllers
{
    public class DefaultController : Controller
    {
        private IEmployee _employees;
        private Interface1 _interface1;
         internal DefaultController(IEmployee emp,Interface1 ii)
         {
            _employees = emp;
            _interface1 = ii;
         }
        // GET: Default
        public ActionResult Index()
        {
            List<Employee> list = _employees.GetEmployees();
            List<Employee> list1 = _interface1.GetAll();
            return View();
        }
    }
}