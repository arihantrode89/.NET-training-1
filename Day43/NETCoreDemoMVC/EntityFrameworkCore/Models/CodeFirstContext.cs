using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Models
{
    public class CodeFirstContext:DbContext
    {
        public CodeFirstContext(DbContextOptions<CodeFirstContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder build)
        {
            build.Entity<Department>().HasData(
                new Department() { DeptId=1,DeptName = "IT" });

            build.Entity<Employee>().HasData(new Employee() {EmployeeId=1, Name = "Arihant", City = "Nagpur", Gender = "Male", Salary = 100000, DepartmentId = 1 });
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
