using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{

    
    class StudentMethod:ViewInterface,DetailsInterface
    {
        
        
        public Student[] InitializeArray(Student[] arr)
        {
            Student[] temparr = new Student[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                temparr[i] = arr[i];
            }
            return temparr;
        }
        public dynamic AddStudent(dynamic arr)
        {
            arr = InitializeArray(arr);
            Console.WriteLine("Enter Details of Students");
            for(int i = arr.Length-1; i < arr.Length; i++)
            {
                arr[i] = new Student();
                Console.WriteLine("Enter Student Id");
                arr[i].Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Student Name");
                arr[i].Name = Console.ReadLine();

                Console.WriteLine("Enter Student Address");
                arr[i].Address = Console.ReadLine();

                Console.WriteLine("Enter Student Obtained Marks");
                arr[i].ObtainedMarks = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter Student Total Marks");
                arr[i].TotalMarks = float.Parse(Console.ReadLine());

            }
            return arr;
        }

        public void ShowDetails(dynamic arr)
        {
            try
            {
                if (arr.Length != 0)
                {
                    foreach (Student item in arr)
                    {
                        Console.WriteLine($"Id:{item.Id}\nName:{item.Name}\nAddress:{item.Address}\n" +
                            $"Obtained Marks:{item.ObtainedMarks}\nTotal Marks:{item.TotalMarks}\n" +
                            $"Percentage:{(item.ObtainedMarks / item.TotalMarks) * 100}");

                        Console.WriteLine("".PadLeft(30, '-'));

                    }
                }
                else
                {
                    throw new ArrayException();
                }
            }
            catch(ArrayException e)
            {
                e.EmptyArray();
            }
        }

        public dynamic SpecificDetails(dynamic arr)
        {
            Console.WriteLine("Enter Id of Student");
            int id = int.Parse(Console.ReadLine());
            try
            {
                if (arr.Length != 0)
                {
                    foreach (Student item in arr)
                    {
                        if (item.Id == id)
                        {
                            return item;
                        }
                    }
                    return null;
                }
                else
                {
                    throw new ArrayException();
                }
            }
            catch(ArrayException e)
            {
                e.EmptyArray();
                return null;
            }

            
        }

        public void DisplaySpecificDetails(dynamic item)
        {
            Console.WriteLine($"Id:{item.Id}\nName:{item.Name}\nAddress:{item.Address}\n" +
                    $"Obtained Marks:{item.ObtainedMarks}\nTotal Marks:{item.TotalMarks}");

            Console.WriteLine("".PadLeft(30, '-'));

        }
        public void UpdateDetails(dynamic arr)
        {
            Console.WriteLine("Entering into updation mode");
            Console.WriteLine("".PadLeft(30, '-'));
            Student OldDetails = SpecificDetails(arr);
            if (OldDetails != null)
            {
                Console.WriteLine("Following are the details you want to update\n");
                DisplaySpecificDetails(OldDetails);
                Console.WriteLine("Choose field for updation\n" +
                    "1.Id\n2.Name\n3.Address\n4.Obtained Marks\n5.Total Marks");
                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter updated Id:");
                        OldDetails.Id = int.Parse(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("Enter updated Name:");
                        OldDetails.Name = Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Enter Updated Address:");
                        OldDetails.Address = Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("Enter Updated Obtained Marks:");
                        OldDetails.ObtainedMarks = float.Parse(Console.ReadLine());
                        break;

                    case 5:
                        Console.WriteLine("Enter Updated Total Marks:");
                        OldDetails.TotalMarks = float.Parse(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Wrong Choice");
                        break;

                }
                Console.WriteLine("details updated successfully");
            }
            else
            {
                Console.WriteLine("No such student exist");
            }
            

        }

        public dynamic DeleteDetails(dynamic arr)
        {
            Console.WriteLine("Enter into deletion mode");
            Console.WriteLine("".PadLeft(30, '-'));

            Student delarr = SpecificDetails(arr);
            if (delarr!=null)
            {
                Console.WriteLine("Follwing are the details you want to delete:\n");
                DisplaySpecificDetails(delarr);

                Array.Clear(arr, Array.IndexOf(arr, delarr), 1);
                Student[] temp = new Student[arr.Length - 1];
                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = arr[i];
                }
                Console.WriteLine("Deleted Successfully");
                return temp;
            }
            else
            {
                Console.WriteLine("No such student exists");
                return arr;
            }
        }
    }
}
