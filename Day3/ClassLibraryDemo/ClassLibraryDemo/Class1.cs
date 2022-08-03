using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDemo
{
    public class Class1
    {
        public int sum(int a,int b)
        {
            return a + b;
        }
        public int subtract(int a, int b)
        {
            return a - b;
        }

        public int multiplication(int a, int b)
        {
            return a * b;
        }
        public int Calculator(int a, int b,int ch)
        {
            switch(ch)
            {
                case 1:
                    return a + b;
                    
                case 2:
                    return a -b;
                    

                case 3:
                    return a * b;
                    
                default:
                    Console.WriteLine("Wrong Choice");
                    return 0;
                    
            }
        }


    }
}
