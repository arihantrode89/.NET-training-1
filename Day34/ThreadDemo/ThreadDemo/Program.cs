using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    internal class Program
    {
        public async static void Method()
        {
            await Task.Run(new Action(longtask));
            Console.WriteLine("Method thread");
        }

        public static void longtask()
        {
            Thread.Sleep(200000);
            Console.WriteLine("--");

        }
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Main Thread");
        }
    }
}
