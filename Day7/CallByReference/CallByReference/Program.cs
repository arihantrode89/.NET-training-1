using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByReference
{
    internal class Program
    {
        /// <summary>
        /// In passing by reference using ref keyword, it is mandatory initialize
        /// </summary>
        /// <param name="a"></param>
        static void callbyref(ref int a,ref char b)
        {
            a += 1;
            b += (char)23;
        }

        /// <summary>
            ///In pass  by reference using out keyword,it is not mandatory to initialize parameter/variable in main block
            ///but we need to initalize the parameter in the func itself
        /// </summary>
        /// <param name="a"></param>
        static void callbyrefout(out int a,out char b)
        {
            
            a = 0;
            b = 'C';
            a += 1;
        }
        
        static void Main(string[] args)
        {
            int i = 0;
            int j;
            char a = 'D';
            char b;
            Console.WriteLine("i:{0}",i);
            callbyref(ref i,ref a);
            Console.WriteLine("i:{0}", i);
            Console.WriteLine(a);


            callbyrefout(out j,out b);
            Console.WriteLine(j);
            Console.WriteLine(b);

            //Tuple<char,char>[] t = new Tuple<char, char>[10];
            //t[0] = Tuple.Create(a,b);
            //Console.WriteLine(t);


        }
    }
}
