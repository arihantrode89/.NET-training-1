using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetWithTwoTables
{
    internal class EmpDeptExceptions:ApplicationException
    {
        public void InvalidDept()
        {
            Console.WriteLine("No such department exist");
        }
        public void EmptyDatabase()
        {
            Console.WriteLine("Empty Database");
        }
    }
}
