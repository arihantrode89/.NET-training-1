using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_Entity_Practice.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext():base("EmployeeContext")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}