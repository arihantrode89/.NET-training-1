using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlingDemo
{
    internal class SubscriberClass
    {
        static void Main(string[] args)
        {
            PublisherClass obj = new PublisherClass();
            obj.ev_OddNumber += new PublisherClass.dg_OddNumber(Message);
            obj.ev_OddNumber += new PublisherClass.dg_OddNumber(Alert);

            obj.add();
        }

        public static void Message()
        {
            Console.WriteLine("Event Executed:Number is Odd"); 
        }

        public static void Alert()
        {
            Console.WriteLine("Alert message popped");
        }
    }

    class PublisherClass
    {
        public delegate void dg_OddNumber();
        public event dg_OddNumber ev_OddNumber;

        public void add()
        {
            int result = 4 + 5;
            if((result%2!=0) && (ev_OddNumber != null))
            {
                ev_OddNumber();
            }
        }
    }
}
