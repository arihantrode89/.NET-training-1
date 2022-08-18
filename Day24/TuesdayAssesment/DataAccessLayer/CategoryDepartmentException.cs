using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class CategoryDepartmentException:ApplicationException
    {
        public void EmptyDatabase(string dbName)
        {
            Console.WriteLine($"{dbName} database is Empty");
        }

        public void InvalidId(string str)
        {
            Console.WriteLine($"Invalid {str}Id");
        }

        public void InvalidCategory(string ctg)
        {
            Console.WriteLine($"{ctg} Category doesnot exist Exist");
        }

        public void PrimaryKeyException()
        {
            Console.WriteLine("You cannot use this id as it is already present in database");
        }
    }
}
