using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModelDemo.Models;
using ViewModelDemo.ViewModels;

namespace ViewModelDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult EmployeeDetails()
        {
            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Arihant",
                Gender = "Male",
                Department = "IT",
                Salary = 40000,
                AddressId = 1001
            };

            Address address = new Address()
            {
                Id=1001,
                Country="India",
                State="Maharashtra",
                City="Nagpur",
                PostalCode=440008
            };

            EmployeeDetailsViewModel obj = new EmployeeDetailsViewModel()
            {
                Employee=employee,
                Address=address,
                PageTitle="Employee Details",
                PageHeader="Employee Header"
            };
            return View("View",obj);
        }
    }
}