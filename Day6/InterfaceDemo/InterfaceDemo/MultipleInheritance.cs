using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class MultipleInheritance : Iwork, IAwork
    {

        public int add(int x, int y)
        {
            return x + y;
        }
        public void method()
        {
            Console.WriteLine("this method is from IAwork");
        }

        public void mothod1()
        {
            Console.WriteLine("this method1 is from IAwork");

        }

        public void work()
        {
            Console.WriteLine("this work is from Iwork");

        }

        public void work1()
        {
            Console.WriteLine("this work1 is from Iwork");

        }
    }
}
