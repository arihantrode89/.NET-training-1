using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGeneric_QueueDemo
{
    
    internal class Program
    {

        static void Main(string[] args)
        {
            Queue que = new Queue();

            que.Enqueue("Arihant");
            que.Enqueue("Manoj");
            que.Enqueue("Rode");

            foreach(var item in que)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("".PadLeft(30, '-'));

            Console.WriteLine("Using Contains(Arihant): "+que.Contains("Arihant"));
            Console.WriteLine("Using Count:" + que.Count);

            Console.WriteLine("".PadLeft(30, '-'));

            Console.WriteLine("After Dequeue:");
            que.Dequeue();
            foreach (var item in que)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("".PadLeft(30, '-'));

            Console.WriteLine("Using Contains(Arihant): " + que.Contains("Arihant"));

            Console.WriteLine("".PadLeft(30, '-'));

            Console.WriteLine($"Top element of queue : {que.Peek()}");
        }
    }
}
