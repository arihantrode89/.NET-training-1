using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListDemo
{

    internal class Program
    {
        static void Main(string[] args)
        {

            List<String> list = new List<string>()
            {
                "India","Germany","USA","Nepal"
            };

            list.Add("Nagpur");
            list.Add("Bangalore");
            list.Add("Lucknow");

            foreach(string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("".PadLeft(30,'-'));

            list.Remove("Nepal");
            Console.WriteLine("After Remove(Nepal): ");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("".PadLeft(30, '-'));


            list.Reverse();
            Console.WriteLine("After Reverse Method:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("".PadLeft(30, '-'));

            list.Sort();
            Console.WriteLine("After Sort Method:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("".PadLeft(30, '-'));

            Console.WriteLine($"Using Contains(India):{list.Contains("India")}");

            Console.WriteLine("".PadLeft(30, '-'));

            var list1 = list.GetRange(0,3);
            Console.WriteLine("Using GetRange(0,3): ");
            foreach (string item in list1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("".PadLeft(30, '-'));

            Console.WriteLine($"Using Count:{list.Count}");
            
            Console.WriteLine("".PadLeft(30, '-'));

            Console.WriteLine($"Using BinarySearch(India): {list.BinarySearch("India")}");

        }
    }
}
