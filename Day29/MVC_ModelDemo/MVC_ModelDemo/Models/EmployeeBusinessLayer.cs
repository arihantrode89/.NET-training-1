using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_ModelDemo.Models
{
    public class EmployeeBusinessLayer
    {

        public List<Employee> employees = new List<Employee>();
        public List<Employee> GetEmployeeDetails(int empid)
        {
            Employee emp = new Employee()
            {
                Id = empid,
                Name = "Arihant",
                Address = "Deshpande Layout",
                City = "Nagpur",
                Email = "arihantrode89@gmail.com"
            };

            employees.Add(emp); 
            return employees;

        }

        public void CreateEmploye(int Id,string Name,string Address,string City,string Email)
        {
            Employee emp = new Employee();
            emp.Id = Id;
            emp.Name = Name;
            emp.Address = Address;
            emp.City = City;
            emp.Email = Email;
            employees.Add(emp);
        }           

        
    }
}