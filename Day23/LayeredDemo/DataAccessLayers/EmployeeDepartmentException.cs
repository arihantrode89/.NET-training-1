using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayers
{
    internal class EmployeeDepartmentException:ApplicationException
    {
        public void EmptyDatabase()
        {
            Console.WriteLine("Database is Empty!");
        }

        public void InvalidId()
        {
            Console.WriteLine("No such data with this id exist");
        }

        public void InvalidDepartment()
        {
            Console.WriteLine("No such department exist");
        }
    }
}
