using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{
    class Example
    {
        int _age, _id;
        string _name;

        //Properties are used set and get the values of private fields/members,
        //so that we can access private members using class object
        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public int id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
    //internal class LaptopApp
    //{

    //    static void Main(string[] args)
    //    {
    //        int[] a;
    //        a = new int[2] { 1, 2 };

    //        Example p2 = new Example();
    //        p2.age = 34;
    //        Console.WriteLine(p2.age);

    //        p2.id = 7070;
    //        Console.WriteLine(p2.id);

    //        p2.name = "Arihant";
    //        Console.WriteLine(p2.name);

    //        string s1 = p2.name;
    //        s1 = "ode";
    //        Console.WriteLine(p2.name);

    //        float d = 10.553f;
    //        long b = 12L;
    //        Console.WriteLine(Convert.ToInt32(d + b));


    //        //}
    //    }
}


