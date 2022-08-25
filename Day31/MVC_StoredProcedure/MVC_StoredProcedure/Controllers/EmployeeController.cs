using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_StoredProcedure.Models;

namespace MVC_StoredProcedure.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult GetEmployee()
        {
            var context = new EmployeeContext();
            var employee = context.Employees.ToList();
            return View(employee);
        }

        public ActionResult GetDepartment()
        {
            var context = new EmployeeContext();
            var employee = context.Departments.ToList();
            return View(employee);
        }

        public ActionResult EditEmployee(int id)
        {
            var context = new EmployeeContext();
            
            var employee = context.Employees.Where(s => s.Id == id).FirstOrDefault();
            return View(employee);
        }

        [HttpPost]
        public ActionResult EditEmployee(int Id, string Name, string Email, string Phone, string Position, int DepartmentId)
        {
            var context = new EmployeeContext();
            context.Database.ExecuteSqlCommand($"UpdateEmployee {Id},'{Name}','{Email}','{Phone}','{Position}','{DepartmentId}'");
            return View("GetEmployee",context.Employees.ToList());
        }

        public ActionResult EditDepartment(int id)
        {
            var context = new EmployeeContext();
            var dept = context.Departments.Where(s => s.Id == id).FirstOrDefault();
            return View(dept);
        }

        [HttpPost]
        public ActionResult EditDepartment(int Id, string Name, string Location)
        {
            var context = new EmployeeContext();
            context.Database.ExecuteSqlCommand($"UpdateDepartment {Id},'{Name}','{Location}';");

            return View("GetDepartment", context.Departments.ToList());
        }

        public ActionResult DeleteEmployee(int id)
        {
            var context = new EmployeeContext();
            context.Database.ExecuteSqlCommand($"DeleteEmployee {id}");
            return View("GetEmployee", context.Employees.ToList());
        }

        public ActionResult DeleteDepartment(int id)
        {
            var context = new EmployeeContext();
            context.Database.ExecuteSqlCommand($"DeleteDepartment {id}");
            return View("GetDepartment", context.Departments.ToList());
        }
        public ActionResult GetEmpDetails(int id)
        {
            var context = new EmployeeContext();
            var data = context.Employees.Where(s => s.Id == id).FirstOrDefault();
            return View(data);
        }

        public ActionResult AddEmployee()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult AddEmployee(string Name, string Email, string Phone, string Position, int DepartmentId)
        {
            if (ModelState.IsValid)
            {
                var context = new EmployeeContext();
                context.Database.ExecuteSqlCommand($"InsertEmployee '{Name}','{Email}','{Phone}','{Position}',{DepartmentId} ");
                var data = context.Employees.ToList();
                return View("GetEmployee", data);
            }
            else
            {
                return Redirect("Index");
            }
        }
        public ActionResult AddDepartment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDepartment(string Name, string Location)
        {
            var context = new EmployeeContext();
            context.Database.ExecuteSqlCommand($"InsertDept '{Name}','{Location}' ");
            return View("GetEmployee", context.Employees.ToList());
        }
    }
}