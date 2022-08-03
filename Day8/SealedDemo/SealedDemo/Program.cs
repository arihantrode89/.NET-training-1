using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedDemo
{

    sealed class demo
    {
        public void display()
        {
            Console.WriteLine("Sealed Class");
        }
  
    }
    

   
    //class B : demo
    //{
    //    //we cannot derive sealed class
    //}

    
    internal class Program
    {
        static void Main(string[] args)
        {
            //we can use sealed class by creating its object
            demo d = new demo();
            d.display();
            Console.WriteLine("Arihant");
        }
    }
}
