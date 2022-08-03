using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyDemo
{
    class User
    {
        public readonly string name = "Arihant";
        public readonly byte age;
        public readonly string location;

      
        public User()
        {
            age = 22;
            location = "Nagpur";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
           
            Console.WriteLine($"Name:{user.name}\nAge:{user.age}\nLocation:{user.location}");
        }
    }
}
