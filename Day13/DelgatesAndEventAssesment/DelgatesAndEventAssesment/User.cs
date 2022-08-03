using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelgatesAndEventAssesment
{
    internal class User
    {
        public User(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine($"Welcome {Name}!\n");
        }
        

    }
}
