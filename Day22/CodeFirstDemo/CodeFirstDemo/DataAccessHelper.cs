using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    internal class DataAccessHelper
    {
        CodeFirstContext _dbcontext = new CodeFirstContext();

        public List<Employee> FetchEmployess()
        {
            return _dbcontext.Employees.ToList();
        }

        public List<Department> FetchDepartment()
        {
            return _dbcontext.Departments.ToList();
        }

        public int AddEmployee(Employee e)
        {
            _dbcontext.Employees.Add(e);
            _dbcontext.SaveChanges();
            return e.EmployeeID;
        }

        public int AddDepartment(Department dept)
        {
            _dbcontext.Departments.Add(dept);
            _dbcontext.SaveChanges();
            return dept.DepartmentId;
        }
    }
}
