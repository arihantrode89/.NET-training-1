using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Models
{
    public class ModelContext:DbContext
    {
        public ModelContext(DbContextOptions<ModelContext> options):base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
