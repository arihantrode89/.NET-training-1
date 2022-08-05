using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentUsingDatabase
{
    internal class ExceptionStudent:ApplicationException
    {
        public void InvalidId()
        {
            Console.WriteLine("Invalid Id...No such Id is present in database");
        }

        public void EmptyDatabase()
        {
            Console.WriteLine("Database is Empty!!");
        }
    }
}
