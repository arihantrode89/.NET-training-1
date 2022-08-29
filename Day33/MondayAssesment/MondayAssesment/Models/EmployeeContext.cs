using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MondayAssesment.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext() : base("EmployeeContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().MapToStoredProcedures(
                s => s.Insert(i => i.HasName("InsertEmployee", "dbo"))
                .Update(u => u.HasName("UpdateEmployee"))
                .Delete(d => d.HasName("DeleteEmployee", "dbo")));

            modelBuilder.Entity<Department>().MapToStoredProcedures(
                s => s.Insert(i => i.HasName("InsertDepartment", "dbo"))
                .Update(u => u.HasName("UpdateDepartment"))
                .Delete(d => d.HasName("DeleteDepartment", "dbo")));
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}