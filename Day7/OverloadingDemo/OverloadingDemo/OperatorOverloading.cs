using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OverloadingDemo
{

    
    internal class OperatorOverloading
    {
        int a, b;

        
        //public OperatorOverloading(int a, int b)
        //{
        //    this.a = a;
        //    this.b = b;
        //}

        public int A { get { return a; } set { a = value; } }

        public int B { get { return b; } set { b = value; } }


        public static int operator + (OperatorOverloading obj,OperatorOverloading obj1)
        { 
            return obj.a * obj1.b;
            
        }

    }
}
