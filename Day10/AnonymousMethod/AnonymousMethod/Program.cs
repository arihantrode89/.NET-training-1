using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    public delegate void Operation();
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Program p = new Program();
            //Anonymous method are created using delegates.
            Operation obj = delegate
            {
                Console.WriteLine("This is anonymous method");
            };
            obj();
        }
    }
}
