using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{
    class Nullable
    {
        public static Nullable<int> i;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //following are the ways of assigning particular data type variables as null
            //Nullable<int> x = null;
            int? x = null;
            int y = x ?? 2;
            Console.WriteLine(y);

            if (x.HasValue)
            { 
                Console.WriteLine("Not empty!"); 
            }
            else
            {
                Console.WriteLine("empty");
            }

            //can also use nullable<> in class and use it
            if(Nullable.i == null)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Console.WriteLine("Non-Empty");
            }
            //Console.WriteLine(x);
            
        }   
    }
}
