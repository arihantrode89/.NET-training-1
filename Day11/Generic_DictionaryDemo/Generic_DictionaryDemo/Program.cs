using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_DictionaryDemo
{
    internal class Program
    {
        int abc()
        {
            return 2 + 4;
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"Nagpur","Orange" }
            };

            dict.Add("Pencil", "Rubber");
            dict.Add("Arihant", "Rode");
            dict.Add("Season", "Rain");

            foreach(var item in dict)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
            Console.WriteLine("".PadLeft(30,'-'));
            Console.WriteLine("Using KeyValuePair<T,T>: ");
            foreach (KeyValuePair<string,string> item in dict)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
            Console.WriteLine("".PadLeft(30, '-'));

            Dictionary<int, string> dict1 = new Dictionary<int, string>()
            {
                { 1,"Arihant"},{ 2,"Nagpur"},{ 3,"Rode"}
            };

            //Access values in Generic Collection
            Console.WriteLine("dict[Pencil]: "+dict["Pencil"]);

            dict.TryGetValue("Pencil", out string result);
            if(result != null)
            {
                Console.WriteLine("Pencil Key Value is " + result);
            }
            else
            {
                Console.WriteLine("Invalid Key");
            }
           
            Console.WriteLine("".PadLeft(30, '-'));

            dict.Remove("Pencil");
            Console.WriteLine("After using Remove(Pencil): ");
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
            Console.WriteLine("".PadLeft(30, '-'));
        }
    }
}
