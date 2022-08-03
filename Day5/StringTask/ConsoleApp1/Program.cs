using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Arihant Rode";
            int len = str.Length;
            Console.WriteLine(str+" "+len);

            str =str.Replace('A', 'a');
            Console.WriteLine(str);

            String substring = str.Substring(0, 5);
            Console.WriteLine(substring);

            Console.WriteLine(str.ToLower());

            Console.WriteLine(str.GetHashCode());
            
            foreach(string item in str.Split(' '))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(str.Contains("han"));

            string  rmstr = str.Remove(1, 2);
            Console.WriteLine();

            string clonestr = (string)str.Clone();
            Console.WriteLine("CLoned String is "+clonestr);

            Console.WriteLine(str.EndsWith("de"));

            
            
            Console.WriteLine(str.TrimStart(new char[] { ' ' }));

            Console.WriteLine("".PadLeft(30,'-'));

            foreach(char i in str.ToCharArray())
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("".PadRight(30, '-'));

            Console.WriteLine(str.ToUpperInvariant());
            Console.WriteLine(str.ToUpper());

            Console.WriteLine(str.StartsWith("ar"));

            Console.WriteLine("Last index of 'a' is "+str.LastIndexOf('a'));

            Console.WriteLine(str.GetType());

            Console.WriteLine(str.IndexOfAny(new char[] {'a','o'}));

            Console.WriteLine(str.Insert(7," Manoj"));

            Console.WriteLine(str.IsNormalized());

            string strrev="";
            foreach(char ch in str.Reverse())
            {
                strrev += ch;
                
            }
            Console.WriteLine("Reversed String is {0}",strrev);
            //Console.WriteLine(str.TrimEnd());





            //char[] strcopy;
            Console.WriteLine();







        }
    }
}
