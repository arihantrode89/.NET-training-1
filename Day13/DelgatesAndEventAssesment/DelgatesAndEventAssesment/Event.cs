using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelgatesAndEventAssesment
{
    internal class Event
    {
        public delegate void Altdelegate(string Name);
        public  event Altdelegate alert;

        public List<string> banned_names = new List<string>() { "Ram", "Sham", "Naveen" };

        public void Attendance()
        {
            
            Console.WriteLine("How many employee are there?");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();
                User user = new User(name);
                if (banned_names.Contains(user.Name))
                {
                    alert(user.Name);
                }
                else
                {
                    user.Display();
                }

            }
        }
    }
}
