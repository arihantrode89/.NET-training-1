using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{

    
    internal class Program
    {
        static void Main(string[] args)
        {
            MultipleInheritance obj = new MultipleInheritance();
            Console.WriteLine(obj.add(4, 5));
            obj.method();obj.mothod1();obj.work();obj.work1();

            
        }
    }
}
