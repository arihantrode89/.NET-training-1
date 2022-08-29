using MondayAssesment.Filters;
using MondayAssesment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MondayAssesment.Controllers
{
    public class EmployeeController : Controller,IEmployee,IDepartment
    {
        // GET: Employee

        [EmployeeException]
        public ActionResult GetEmployees()
        {
            var db = new EmployeeContext();
            var Data = db.Employees.ToList();
            if(Data.Count > 0)
            {
                return View(Data);
            }
            else
            {
                throw new Exception("Your Employee Database is Empty");
            }
            
        }

        [ParticularEmployeeException]
        public ActionResult GetEmployeesByDepartment(int id)
        {
            var db = new EmployeeContext();
            var Data = db.Employees.Where(s=>s.DepartmentId==id).ToList();
            if (Data.Count > 0)
            {
                return View("GetEmployees", Data);
            }
            else
            {
                var name = db.Departments.Where(s => s.DeptId == id).Select(s => s.DeptName).FirstOrDefault();
                throw new Exception($"{name} has 0 Employees so you need to add employees first");
            }

        }
        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee emp)
        {
            if (ModelState.IsValid)
            {
                var db = new EmployeeContext();
                db.Database.ExecuteSqlCommand($"InsertEmployee '{emp.Name}','{emp.Gender}','{emp.City}',{emp.Salary},{emp.DepartmentId}");
                return Redirect("GetDepartment");
            }
            return View();
        }

        [DepartmentException]
        public ActionResult GetDepartment()
        {
            var db = new EmployeeContext();
            var data = db.Departments.ToList();
            if(data.Count > 0)
            {
                return View(data);

            }
            else
            {
                throw new Exception("Your Department Table is Empty.You need to add dept first to view Departments");
            }
        }

        public ActionResult AddDepartment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDepartment(Department dept)
        {
            if (ModelState.IsValid)
            {
                var db = new EmployeeContext();
                db.Database.ExecuteSqlCommand($"InsertDepartment '{dept.DeptName}' ");
                return Redirect("GetDepartment");
            }
            return View();
        }

        public ActionResult UpdateEmployee(int id)
        {
            var db = new EmployeeContext();
            var data = db.Employees.Where(s => s.EmployeeId == id).FirstOrDefault();
            return View(data);
        }

        [HttpPost]
        public ActionResult UpdateEmployee(Employee emp)
        {
            if (ModelState.IsValid)
            {
                var context = new EmployeeContext();
                context.Database.ExecuteSqlCommand($"UpdateEmployee {emp.EmployeeId},'{emp.Name}','{emp.Gender}','{emp.City}',{emp.Salary},{emp.DepartmentId}");

                return Redirect("~/Employee/GetDepartment");
            }
            return View();
        }

        public ActionResult UpdateDepartment(int id)
        {
            var db = new EmployeeContext();
            var data = db.Departments.Where(s => s.DeptId == id).FirstOrDefault();
            return View(data);
        }

        [HttpPost]
        public ActionResult UpdateDepartment(Department dept)
        {
            if (ModelState.IsValid)
            {
                var context = new EmployeeContext();
                context.Database.ExecuteSqlCommand($"UpdateDepartment {dept.DeptId},'{dept.DeptName}' ");

                return Redirect("~/Employee/GetDepartment");
            }
            return View();
        }

        public ActionResult DeleteEmployee(int id)
        {
            var db = new EmployeeContext();
            db.Database.ExecuteSqlCommand($"DeleteEmployee {id}");
            return Redirect("~/Employee/GetDepartment");
        }
        public ActionResult DeleteDepartment(int id)
        {
            var db = new EmployeeContext();
            db.Database.ExecuteSqlCommand($"DeleteDepartment {id}");
            return Redirect("~/Employee/GetDepartment");
        }
    }
}