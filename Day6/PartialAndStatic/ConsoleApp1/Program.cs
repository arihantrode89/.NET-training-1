using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Partial1 obj = new Partial1();
            obj.Name = "Arihant Rode";
            obj.Id = 7070;
            obj.Role = "Trainee Software Engineer";
            obj.Gender = "Male";
            obj.Display();

            Console.WriteLine(staticdemo.calculation(4, 4));

        }
    }

    
}
