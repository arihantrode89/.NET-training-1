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

        public ActionResult GetEmpDetails(int id)
        {
            var context = new EmployeeContext();
            var data = context.Employees.Where(s => s.Id == id).FirstOrDefault();
            return View(data);
        }
        public void AddEmployee()
        {
            //EmployeeContext context = new EmployeeContext();
            //Department dept = new Department()
            //{
            //    Id=100,
            //    Name="Information Technology",
            //    Location="Bangalore",
            //    Employees=new List<Employee>() 
            //    { 
            //        new Employee(){ Id=1,Name="Arihant",Email="arihantrode89@gmail.com",Phone="9637010084",Position="Software Engineer"},
            //        new Employee(){ Id=2,Name="Ayushya",Email="ayushya@gmail.com",Phone="9637320084",Position="Software Engineer"},
            //        new Employee(){ Id=3,Name="Ayush",Email="Ayush@gmail.com",Phone="9637340084",Position="Software Tester"},
            //        new Employee(){ Id=4,Name="Amit",Email="Amit@gmail.com",Phone="9667010084",Position="Software Engineer"},
            //        new Employee(){ Id=5,Name="Ashish",Email="Ashish@gmail.com",Phone="9656010084",Position="Software Engineer"},
            //        new Employee(){ Id=6,Name="Aditya",Email="Aditya@gmail.com",Phone="9637810084",Position="Software Tester"},
            //    }
            //};
            //context.Departments.Add(dept);
            //context.SaveChanges();
        }
    }
}