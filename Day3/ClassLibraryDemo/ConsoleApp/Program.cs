using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDemo;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            Console.WriteLine("Sum is {0}", obj.sum(3, 4));
            Console.WriteLine("Subtraction is {0}", obj.subtract(4, 3));
            Console.WriteLine("Multiplication is {0}", obj.multiplication(3, 4));

            Console.WriteLine("Sum is {0}", obj.Calculator(3, 4,1));
            Console.WriteLine("Subtraction is {0}", obj.Calculator(4, 3,2));
            Console.WriteLine("Multiplication is {0}", obj.Calculator(3, 4,3));



        }
    }
}
