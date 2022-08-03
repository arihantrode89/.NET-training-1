using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = Console.ReadLine();
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num.GetType());

            char ch = Console.ReadLine()[0];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            //switch (ch) {
            //    case 'A':
            //        Console.WriteLine("HI");
            //        break;
            //    case 'B':
            //        Console.WriteLine("Bye");
            //        break;
            //    default:
            //        Console.WriteLine("Default" + " "+ num);
            //        break;

            //}
            //Console.WriteLine("Welcome to Day1 of Training"+" "+name +" ");
        }
    }
}
