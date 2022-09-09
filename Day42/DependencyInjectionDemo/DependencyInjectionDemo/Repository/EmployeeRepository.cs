using DependencyInjectionDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjectionDemo.Repository
{
    public class EmployeeRepository : IEmployee
    {
        private List<Employee> _employees = new List<Employee>();
        public List<Employee> GetEmployees()
        {
            _employees.Add(new Employee() { Id = 1, Name = "Arihant", Gender = "Male" });
            _employees.Add(new Employee() { Id = 2, Name = "Ayushya", Gender = "Female" });
            _employees.Add(new Employee() { Id = 3, Name = "Arihant", Gender = "Male" });
            return _employees;
        }
    }
}