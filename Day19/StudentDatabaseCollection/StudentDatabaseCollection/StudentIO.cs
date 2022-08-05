using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentUsingDatabase
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
        public void AddStudent()
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

            stdservice.AddStudentDetails(Id,Name,Address,TotalMarks,ObtainedMarks);

        }

        public void Update() 
        {
            Console.WriteLine("Enter id for updation:");
            int id = int.Parse(Console.ReadLine());
            
            if (stdservice.ShowSpecificDetails(id))
            {
                Boolean flag;
                do
                {
                    flag = stdservice.UpdateStudent(id);


                } while (flag);
            }
            else
            {
            }
        }

        public void DeleteStudent()
        {
            int id;
            Console.WriteLine("Enter id for deletion");
            id = int.Parse(Console.ReadLine());
            if (stdservice.DeleteDetails(id))
            {
                Console.WriteLine("Data Deleted Succesfully");
            }
            else
            {
                Console.WriteLine("Error Occurred");
            }
        }

        public void ShowDetails()
        {
            Console.WriteLine("Following are the Student Details\n");
            stdservice.ShowDetails();
        }

        public void SpecificDetails()
        {
            Console.WriteLine("Enter Id for Specific Details");
            int id = int.Parse(Console.ReadLine());
            stdservice.ShowSpecificDetails(id);
        }
    }
}
