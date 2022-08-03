using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{

    class Xyz
    {
        public void UserControl()
        {
            Console.WriteLine("this is Xyz");
        }
    }
    internal class Program:Xyz,Iact,Iglobal
    {

        void Iact.UserControl()
        {
            Console.WriteLine("THis is IACT");
        }

        void Iglobal.UserControl()
        {
            Console.WriteLine("this is Iglobal");
        }

        void UserControl()
        {
            Console.WriteLine("this is ABC");
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.UserControl();

            Iact obj1 = new Program();
            obj1.UserControl();
           

            Iglobal obj2 = new Program();
            obj2.UserControl();

            Xyz xyz = new Program();
            xyz.UserControl();

        }
    }
}
