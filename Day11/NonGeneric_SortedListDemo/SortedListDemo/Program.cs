using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Initialization and Add Method
            SortedList sort = new SortedList();

            sort.Add(1, "Mon");
            sort.Add(2, "Tue");
            sort.Add(3, "Wed");
            sort.Add(4, "Thur");
            sort.Add(5, "Fri");

            #endregion

            #region Accessing value using foreach and for loop
            Console.WriteLine("Using foreach:");
            foreach(DictionaryEntry item in sort)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
            Console.WriteLine("".PadLeft(30,'-'));

            Console.WriteLine("Using for loop:");
            for(int i = 0; i < sort.Count; i++)
            {
                Console.WriteLine($"{sort.GetKey(i)}:{sort.GetByIndex(i)}");

            }
            Console.WriteLine("".PadLeft(30, '-'));

            #endregion

            #region ContainsKey Method
            Console.WriteLine("Using ContainsKey(1): "+ sort.ContainsKey(1));
            
            Console.WriteLine("".PadLeft(30, '-'));

            #endregion

            #region IndexofKey Method
            Console.WriteLine("Using IndexofKey(1):  " + sort.IndexOfKey(1));

            Console.WriteLine("".PadLeft(30,'-'));

            #endregion

            #region Using Values Property
            Console.WriteLine("Using Values Property:");
            ArrayList arr = new ArrayList(sort.Values);
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("".PadLeft(30, '-'));
            #endregion

            #region Remove Method
            sort.Remove(1);
            Console.WriteLine("Using Remove(1):");
            foreach(DictionaryEntry item in sort)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
            Console.WriteLine("".PadLeft(30, '-'));
            #endregion
        }
    }
}
