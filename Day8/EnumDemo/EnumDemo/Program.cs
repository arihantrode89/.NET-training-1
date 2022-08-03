using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    internal class Program
    {
        enum Week
        {
            Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday //by default values assigned to const are from 0
        }

        enum color
        {
            Red = 1,Green,Blue //we can explicitly give values to enum values
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine(Week.Sunday);

            int a = (int)Week.Sunday;
            int b = (int)Week.Monday;
            int c = (int)Week.Friday;



            Console.WriteLine($"Sunday:{a}\nMonday:{b}\nFriday:{c}\n");
            Console.WriteLine($"Red:{(int)color.Red}\nGreen:{(int)color.Green}\nBlue:{(int)color.Blue}");


        }
    }
}
