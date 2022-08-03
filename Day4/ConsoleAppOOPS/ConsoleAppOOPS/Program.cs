using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class Sample
    {
        public Sample()
        {
            Samplefunc();
        }
        public void Samplefunc()
        {
            Console.WriteLine("This is sample method");
        }

        public int Samplefunc(int a)
        {
            Console.WriteLine("This is sample method"+a);
            return a;
        }
    }

    class Sample1 : Sample
    {
        public  new int  Samplefunc()
        {
            return 4 - 5;
        }
    }

    abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("Abstract Class Constructor");
        }
        public void Age(int age)
        {
            Console.WriteLine("Age is " + age);
        }

        public abstract void isalive();
    }

    class Dog : Animal
    {
        public int age;
        public Dog(int a)
        {
            age = a;
            Console.WriteLine("Dog Constructor");
        }
        public override void isalive()
        {
            base.Age(age);
            Console.WriteLine("Alive");
        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample1 obj = new Sample1();
            Console.WriteLine(obj.Samplefunc());

            Dog dd = new Dog(12);
            //dd.age(12);
            dd.isalive();
        }
        
    }

    
}
