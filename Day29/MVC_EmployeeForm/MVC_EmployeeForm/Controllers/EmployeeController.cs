using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_EmployeeForm.Models;

namespace MVC_EmployeeForm.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateEmployee(string EmployeeName,string Email,string Phone,string Address,string Password,string Gender,string Department)
        {
            Employee emp = new Employee();
            emp.Name = EmployeeName;
            emp.Email = Email;
            emp.Phone = Phone;
            emp.Address = Address;
            emp.Password = Password;
            emp.Gender = Gender;
            emp.Department = Department;
            return View("EmployeeDetails",emp);
        }
    }
}