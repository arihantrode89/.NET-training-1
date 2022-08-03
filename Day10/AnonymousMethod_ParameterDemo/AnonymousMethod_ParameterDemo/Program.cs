
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod_ParameterDemo
{
    public delegate void HelpMethod(int y);
    internal class Program
    {
        static void Method1(HelpMethod obj,int x)
        {
            x += 10;
            obj(x);
        }
        
        static void Main(string[] args)
        {
      
            Method1(delegate(int val)
            {
                Console.WriteLine($"{val}");
            }, 10);

            

            
        }
    }
}
