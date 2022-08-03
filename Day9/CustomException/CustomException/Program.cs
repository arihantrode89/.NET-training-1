using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{

    class MyException : ApplicationException
    {
        public void MessageException()
        {
            Console.WriteLine("Do not divide by zero");
        }
        public void NegativeException()
        {
            Console.WriteLine("Result should not less than 0");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int div, d;
            div = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            try
            {

                if (div == 0)
                {
                    throw new MyException();
                }
            }
            catch (MyException e)
            {
                e.MessageException();
            }
            //int r = d / div;
            try
            {
                int r = d / div;
                if (r<0)
                {
                    throw new MyException();
                }
            }
            catch(MyException e)
            {
                e.NegativeException();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            
            
            
        }
    }
}
