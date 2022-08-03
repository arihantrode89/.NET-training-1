using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingDemo
{

    class Overloading
    {
        public static double area(double len,double breadth)
        {
            return len * breadth;
        }

        public static double area(double radius)
        {
            double pi = 3.14;
            return pi*(radius*radius);
        }
    }
    internal class Program
    {
        public 
        static void Main(string[] args)
        {
            //for rectangle area
            Console.WriteLine(Overloading.area(12, 16));

            //for area of circle
            Console.WriteLine(Overloading.area(12));

            OperatorOverloading aa = new OperatorOverloading();
            OperatorOverloading ab = new OperatorOverloading();

            aa.A = 12;
            ab.B = 10;
            aa.B = 10;
            ab.A = 12;

            int bb = aa+ ab;
            Console.WriteLine(bb);


            //Equals func check for the address and not the values
            Console.WriteLine(aa.Equals(ab));

            OperatorOverloading cc = new OperatorOverloading();
            cc = aa;

            Console.WriteLine(aa.Equals(cc));

        }
    }
}
