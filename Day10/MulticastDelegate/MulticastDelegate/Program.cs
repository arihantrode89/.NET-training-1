using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    public delegate void MultiCast(int i,int j);
    internal class Program
    {
        public void Add(int x,int y)
        {
            Console.WriteLine($"Addition is {x + y}");
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine($"Subtraction is {x - y}");
        }

        public void Multiply(int x, int y)
        {
            Console.WriteLine($"Multiplication is {x * y}");
        }

        public void Divide(int x, int y)
        {
            Console.WriteLine($"Division is {x / y}");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            MultiCast d1 = new MultiCast(p.Add);

            d1(20, 20);
            Console.WriteLine("".PadLeft(30, '-'));

            d1 += p.Subtract;
            d1 += p.Multiply;
            d1 += p.Divide;

            //GetInvocationList returns the list of method to be invoke in order.By using this we can invoke method of our choice
            foreach (MultiCast obj in d1.GetInvocationList())
            {
                try
                {
                    obj.Invoke(40, 0);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Method Name:{obj.Method.Name}\tException:{e.Message}");

                }
            }

            Console.WriteLine("".PadLeft(30, '-'));

            d1(20, 20);

            Console.WriteLine("".PadLeft(30, '-'));

            d1 -= p.Subtract;
            d1 -= p.Divide;

            d1(20, 20);
        }
    }
}
