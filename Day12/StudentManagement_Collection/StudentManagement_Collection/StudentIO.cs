using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_Collection
{
    internal class StudentIO
    {
        StudentService stdservice = new StudentService();
        public byte Menu()
        {
            Console.WriteLine("1.Add Student\n2.Update Student Details\n3.Show Students Details\n" +
                "4.Show Specific Student Details\n5.Delete Student Detail\n6.Exit\n");

            byte ch = byte.Parse(Console.ReadLine());

            return ch;
        }

        public void Add()
        {
            Console.WriteLine("Enter Student Id");
            int Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Name");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter Student Address");
            string Address = Console.ReadLine();

            Console.WriteLine("Enter Student Obtained Marks");
            float ObtainedMarks = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Total Marks");
            float TotalMarks = float.Parse(Console.ReadLine());

            stdservice.AddStudent(Id, Name, Address, TotalMarks, ObtainedMarks);

        }

        public void AllDetails()
        {
            stdservice.ShowDetails();
        }
        public void Update()
        {
            
            Console.WriteLine("Enter id for updation:");
            int id = int.Parse(Console.ReadLine());
            Boolean flag;
            do
            {
                flag = stdservice.UpdateDetails(id);

            } while (flag);
            
        }

        public void Delete()
        {
            Console.WriteLine("Enter Id for deletion");
            int id = int.Parse(Console.ReadLine());
            if (stdservice.DeleteDetails(id))
            {
                Console.WriteLine("Details deleted Successfully");
            }
            else
            {
                Console.WriteLine("No details are present");
            }
        }

        public void SpecificDetail()
        {
            Console.WriteLine("Enter Id for details");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine($"Following are the details of ID:{id}");
            stdservice.DisplaySpecificDetail(id);
            
        }


    }
}
