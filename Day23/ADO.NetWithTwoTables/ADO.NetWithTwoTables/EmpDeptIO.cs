using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetWithTwoTables
{
    internal class EmpDeptIO
    {
        EmpDeptService empDeptService = new EmpDeptService();
        public byte Menu()
        {
            Console.WriteLine("1.Add Employee\n2.Update Employee Details\n3.Show Employee Details\n" +
                "4.Show Specific Employee Details\n5.Delete Employee Detail\n6.Exit\n");

            byte ch = byte.Parse(Console.ReadLine());

            return ch;
        }
        public void AddStudent()
        {
            Console.WriteLine("Enter Employee Id");
            int Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter Employee Phone");
            long Phone = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Email");
            string Email = Console.ReadLine();

            Console.WriteLine("Enter Employee Role");
            string Role = Console.ReadLine();

            Console.WriteLine("Enter Employee Date of Birth");
            string Dob = Console.ReadLine();

            Console.WriteLine("Enter Employee Gender ");
            char Gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Band");
            char Band = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Grade");
            string Grade = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary");
            float Sal = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Date of Joining");
            string Doj = Console.ReadLine();

            Console.WriteLine("Enter Employee Department Name");
            string Dept = Console.ReadLine();

            empDeptService.AddEmployee(Id, Name, Phone, Email, Role,Dob,Gender,Band,Grade,Sal,Doj,Dept);

        }

        public void Update()
        {
            Console.WriteLine("Enter id for updation:");
            int id = int.Parse(Console.ReadLine());

            if (empDeptService.ShowSpecificDetails(id))
            {
                Boolean flag;
                do
                {
                    flag = empDeptService.UpdateEmployee(id);


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
            if (empDeptService.DeleteDetails(id))
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
            empDeptService.ShowDetails();
        }

        public void SpecificDetails()
        {
            Console.WriteLine("Enter Id for Specific Details");
            int id = int.Parse(Console.ReadLine());
            empDeptService.ShowSpecificDetails(id);
        }

    }
}
