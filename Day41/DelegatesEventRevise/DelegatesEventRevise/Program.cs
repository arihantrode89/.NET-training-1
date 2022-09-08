using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventRevise
{
    internal class Program
    {
        public delegate int Mydelegate(int a, int b);

        public delegate T MyGenericdelegate<T>(T a, T b);
        static void Main(string[] args)
        {
            //delegates
            Mydelegate a1 = Sum;
            Mydelegate a2 = new Mydelegate(Sum);
            Mydelegate a3 = (int a,int b) => a * b;

            //Multicast
            a1 += Sub;

            Console.WriteLine(a1.Invoke(10, 20));
            //Console.WriteLine(a2(10, 20));
            //Console.WriteLine(a1 == a2);

            //delegate as a parameter
            Mul(a3);

            foreach(var a in a1.GetInvocationList())
            {
                Console.WriteLine(a.DynamicInvoke(10,20));
            }

            Func<int, int, int> abc = (int a, int b) => a % b;
            Console.WriteLine(abc(100,200));

            Action<int,int> bb = (int a,int b)=>Console.WriteLine(a % b);
            bb(10, 20);
            bb+=delegate (int a,int b) { Console.WriteLine(a + b); };
            bb(10, 20);


            Predicate<int> cc = (int a) => a % 2 == 0;
            Console.WriteLine(cc(20));

            MyGenericdelegate<int> m1 = Sum;
            Console.WriteLine(m1(900, 009));
        }

        public static int Sum(int a,int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static void Mul(Mydelegate sm)
        {
            Console.WriteLine(sm(10, 20));
        }
    }
}
