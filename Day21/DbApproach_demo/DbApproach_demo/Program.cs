using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DbApproach_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new NorthwindEntities1())
            {
                var result = context.Employees;
                foreach(var item in result)
                {
                    Console.WriteLine(item.FirstName);
                    Console.WriteLine(item.LastName);
                    Console.WriteLine(item.PostalCode);
                    Console.WriteLine("".PadLeft(30,'-'));

                }
            }
        }
    }
}
