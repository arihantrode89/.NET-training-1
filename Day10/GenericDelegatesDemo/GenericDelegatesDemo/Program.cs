using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegatesDemo
{
    class Myclass
    {
        public static bool Isdate(String Date)
        {
            DateTime dt;
            return DateTime.TryParse(Date, out dt);
        }

        public static int Multi(int a,int b)
        {
            return a + b;
        }

        public static void sum(int a,int b)
        {
            Console.WriteLine($"Sum:{a + b}");
        }

        public static void concat(string str1,string str2)
        {
            Console.WriteLine($"{str1 + str2}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Action delegate takes more than one argument and return nothing 
            Action<int,int> A = new Action<int, int>(Myclass.sum);
            A(10, 20);

            //Func delegate takes more than one argument and return some value.last param is for return value
            Func<int,int,int> B = new Func<int,int,int>(Myclass.Multi);
            B(10, 20);

            //predective takes values and return boolean value
            Predicate<String> C = new Predicate<string>(Myclass.Isdate);
            if (C("20-07-2022"))
            {
                Console.WriteLine("Date is valid");
            }
            else
            {
                Console.WriteLine("Date is not valid");
            }

            Action<string, string> D = new Action<string, string>(Myclass.concat);
            D("Arihant", "Rode");




        }
    }
}
