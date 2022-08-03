using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UserCollection
{
    internal class Student
    {
        int id;
        string _name,_email,_role;
        public Dictionary<int, List<string>> details = new Dictionary<int, List<string>>();
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Role { get { return _role; } set { _role = value; } }



        public void GetData1(int i=0)
        {
            Console.WriteLine($"Enter Details of Student No.{i+1}\n");
            Console.WriteLine("Enter Student Id:");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Student Email:");
            Email = Console.ReadLine();
            Console.WriteLine("Enter Student Role:");
            Role = Console.ReadLine();

        }
        public void GetData2()
        {
            Console.WriteLine("How many student details you want to add?");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Enter Details of Student No.{i + 1}\n");
                Console.WriteLine("Enter Student Id:");
                Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student Name:");
                Name = Console.ReadLine();
                Console.WriteLine("Enter Student Email:");
                Email = Console.ReadLine();
                Console.WriteLine("Enter Student Role:");
                Role = Console.ReadLine();
                var aa = new List<string>() { Name, Email, Role };
                details.Add(Id,aa);
            }
        }
        public void Display()
        {
            Console.WriteLine($"Id:{Id}\nName:{Name}\nEmail:{Email}\nRole:{Role}");
        }
        public void Display1()
        {
            foreach(KeyValuePair<int,List<string>> item in details) 
            {

                Console.WriteLine($"Id:{item.Key}\nName:{item.Value[0]}\nEmail:{item.Value[1]}\nRole:{item.Value[2]}");

            }
        }

        
        public void UpdateData()
        {
            GetData1();
            Console.WriteLine("Your details are updated!");
        }

    }
}
