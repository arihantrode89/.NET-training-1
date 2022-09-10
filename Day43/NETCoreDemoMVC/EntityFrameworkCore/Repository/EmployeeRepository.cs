using EntityFrameworkCore.Models;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkCore.Repository
{
    public class EmployeeRepository:IEmployee
    {
        private ModelContext _context;
        public EmployeeRepository(ModelContext context)
        {
            _context = context;
        }
        public List<Employee> GetEmployees()
        {
           
            return _context.Employees.ToList();  

        }
    }
}
