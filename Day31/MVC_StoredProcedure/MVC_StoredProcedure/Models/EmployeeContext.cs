using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace MVC_StoredProcedure.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext() : base("EmployeeContext")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().MapToStoredProcedures(
                s => s.Insert(i => i.HasName("InsertEmployee", "dbo"))
                .Update(u => u.HasName("UpdateEmployee"))
                .Delete(d => d.HasName("DeleteEmployee", "dbo")));
        }
        public virtual void Sp_delete(int id)
        {
            ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<Employee>($"DeleteEmployee {id}");
        }
    }
}