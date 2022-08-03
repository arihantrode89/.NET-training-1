using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_SortedList
{

    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string,string> sort = new SortedList<string,string>();
            sort.Add("Zomato", "Food");
            sort.Add("Myntra", "Clothes");
            sort.Add("Coursera", "Courses");
            sort.Add("Duo", "Security");

            foreach (KeyValuePair<string, string> item in sort)
            {
                Console.WriteLine($"{item.Key} is used for {item.Value}");
            }
            Console.WriteLine("".PadLeft(30,'-'));

            Console.WriteLine($"Using ContainsKey(Zomato):{sort.ContainsKey("Zomato")}");

            Console.WriteLine("".PadLeft(30, '-'));

            Console.WriteLine($"Using ContainsValue(Food):{sort.ContainsValue("Food")}");

            Console.WriteLine("".PadLeft(30, '-'));


            sort.TryGetValue("Myntra", out string result);
            if (result != null)
            {
                Console.WriteLine($"Myntra key having {result} value");
            }
            else
            {
                Console.WriteLine("Myntra is an invalid Key");
            }

            Console.WriteLine("".PadLeft(30, '-'));

            sort.Remove("Duo");
            Console.WriteLine($"After using Remove(Duo):");
            foreach (KeyValuePair<string, string> item in sort)
            {
                Console.WriteLine($"{item.Key} is used for {item.Value}");
            }
            Console.WriteLine("".PadLeft(30, '-'));

            sort["Myntra"] = "Online_Shopping";
            Console.WriteLine("After replacing myntra value:");
            foreach (KeyValuePair<string, string> item in sort)
            {
                Console.WriteLine($"{item.Key} is used for {item.Value}");
            }
            Console.WriteLine("".PadLeft(30, '-'));

        }
    }
}
