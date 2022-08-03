using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    public static class ExtensionMethod
    {
        public static int WordCount(this string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                return str.Split(' ').Count();
            }
            else
            {
                return 0;
            }
        }

        public static Boolean EvenorNot(this byte num)
        {
            return num % 2 == 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "My name is arihant";
            int count = a.WordCount();
            Console.WriteLine(count);

            byte num = 2;
            Console.WriteLine(num.EvenorNot());
        }
    }
}
