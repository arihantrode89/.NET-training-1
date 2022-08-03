using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate string Delegate(int x);
    internal class Program
    {
        string name;
        static string MyString(int i)
        {
            return String.Format($"Static method {i}");
        }

        string InstanceMethod(int j)
        {
            return String.Format($"{name}__{j}");
        }
        static void Main(string[] args)
        {
            Delegate d1 = new Delegate(Program.MyString);
            Program p = new Program();
            p.name = "My Instance";
            Delegate d2 = new Delegate(p.InstanceMethod);

            Console.WriteLine(d1(10));
            Console.WriteLine(d2(10));


        }
    }
}
