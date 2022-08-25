using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Entity_Practice.Models;

namespace MVC_Entity_Practice.Controllers
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
            return View();
        }

        [HttpPost]
        public ActionResult EditEmployee(int Id,string Name,string Email,string Phone,string Position,int DepartmentId)
        {
            var context = new EmployeeContext();
            var emprow = context.Employees.Where(s => s.Id == Id).FirstOrDefault();
            emprow.Name = Name;
            emprow.Email = Email;
            emprow.Phone = Phone;
            emprow.Position = Position;
            emprow.DepartmentId=DepartmentId;
            context.SaveChanges();

            return View("GetEmployee",context.Employees.ToList());
        }

        public ActionResult EditDepartment(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditDepartment(int Id, string Name,string Location)
        {
            var context = new EmployeeContext();
            var deptrow = context.Departments.Where(s => s.Id == Id).FirstOrDefault();
            deptrow.Name = Name;
            deptrow.Location = Location;
            context.SaveChanges();

            return View("GetDepartment", context.Departments.ToList());
        }

        public ActionResult DeleteEmployee(int id)
        {
            var context = new EmployeeContext();
            var data = context.Employees.Where(s => s.Id == id).FirstOrDefault();
            context.Employees.Remove(data);
            context.SaveChanges();
            return View("GetEmployee",context.Employees.ToList());
        }

        public ActionResult DeleteDepartment(int id)
        {
            var context = new EmployeeContext();
            var data = context.Departments.Where(s => s.Id == id).FirstOrDefault();
            context.Departments.Remove(data);
            context.SaveChanges();
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
        public ActionResult AddEmployee(string Name,string Email,string Phone,string Position,int DepartmentId)
        {
            var context = new EmployeeContext();
            Employee emp = new Employee()
            {
                Name = Name,
                Email = Email,
                Phone = Phone,
                Position = Position,
                DepartmentId = DepartmentId
            };
            context.Employees.Add(emp);
            context.SaveChanges();
            var data = context.Employees.ToList();
            return View("GetEmployee",data);
        }
        public ActionResult AddDepartment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDepartment(string Name,string Location)
        {
            var context = new EmployeeContext();
            Department dept = new Department()
            {
                Name = Name,
                Location = Location
            };
            context.Departments.Add(dept);
            context.SaveChanges();
            return View("GetEmployee",context.Employees.ToList());
        }
    }
}