using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_StoredProcedure.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext() : base("EmployeeContext")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        
    }
}