using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorDemo
{
    class Garbage
    {
        int id;
        string str;
        Array arr = new int[] { };
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Garbage obj = new Garbage();

            Console.WriteLine(GC.MaxGeneration);

            Console.WriteLine("Gen:"+GC.GetGeneration(obj));

            Console.WriteLine("Memory:"+GC.GetTotalMemory(false));

            GC.Collect(0);

            Console.WriteLine("After GC.Collect--Memory:"+GC.GetTotalMemory(false));

            Console.WriteLine("Gen:" + GC.GetGeneration(obj));


            Console.WriteLine("Memory:" + GC.GetTotalMemory(false));


            GC.Collect(1);

            Console.WriteLine("After GC.Collect--Memory:" + GC.GetTotalMemory(false));

            Console.WriteLine("Gen:" + GC.GetGeneration(obj));


            Console.WriteLine("Memory:" + GC.GetTotalMemory(false));


            GC.Collect(2);

            Console.WriteLine("After GC.Collect--Memory:" + GC.GetTotalMemory(false));

            Console.WriteLine("Gen:" + GC.GetGeneration(obj));



            //Console.WriteLine(GC.GetTotalMemory(false));
            //GC.Collect();
            //Console.WriteLine(GC.GetTotalMemory(false));
        }
    }
}
