using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Initialization and Add Method
            Hashtable hash  = new Hashtable();

            hash.Add("Nagpur","Metro");
            hash.Add("BMW","Germany");
            hash.Add("Tata", "India");
            hash.Add(1, "Jaipur");

            foreach(DictionaryEntry item in hash)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }

            Console.WriteLine("".PadLeft(30,'-'));

            #endregion

            #region ContainsValue Method
            Console.WriteLine($"After using ContainsValue(Metro): {hash.ContainsValue("Metro")}");

            Console.WriteLine("".PadLeft(30, '-'));

            #endregion

            #region Count Property
            Console.WriteLine($"After Using Count: {hash.Count}");

            Console.WriteLine("".PadLeft(30, '-'));

            #endregion

            #region ContainsKey Method
            Console.WriteLine($"After Using ContainsKey(1): {hash.ContainsKey(1)}");

            Console.WriteLine("".PadLeft(30, '-'));

            #endregion

            #region Remove Method
            Console.WriteLine("After using Remove():");
            hash.Remove(1);
            foreach(DictionaryEntry item in hash)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
            Console.WriteLine("".PadLeft(30, '-'));

            #endregion

            #region Keys Properties
            var key = hash.Keys;
            Console.WriteLine("Keys of HashTable are:");
            foreach(var i in key)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("".PadLeft(30, '-'));

            #endregion
        }
    }
}
