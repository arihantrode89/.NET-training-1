using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using Entity;

namespace LayeredDemo
{
    internal class EmployeeDepartmentIO
    {
        EmployeeDepartmentBusinessLayer obj = new EmployeeDepartmentBusinessLayer();
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
            string Phone = Console.ReadLine();

            Console.WriteLine("Enter Employee Email");
            string Email = Console.ReadLine();

            Console.WriteLine("Enter Employee Role");
            string Role = Console.ReadLine();

            Console.WriteLine("Enter Employee Date of Birth");
            string Dob = Console.ReadLine();

            Console.WriteLine("Enter Employee Gender ");
            char Gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Department Name");
            string Dept = Console.ReadLine();

            Employee Employee = new Employee(Name,Phone,Email,Role,Dob,Gender);
            obj.AddEmployee(Employee, Dept);

        }

        public void Update()
        {
            try
            {
                Console.WriteLine("Enter id for updation:");
                int id = int.Parse(Console.ReadLine());
                bool? spec = obj.ShowSpecifcDetails(id);
                if (spec == true)
                {
                    Boolean flag;
                    do
                    {
                        Console.WriteLine("Choose what you want to update\n" +
                            "1.Name\n2.Phone\n3.Email \n4.Role\n5.Department\n6.Exit\n");
                        byte ch = byte.Parse(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                obj.UpdateEmployee(id, "Name");
                                flag = true;
                                break;
                            case 2:
                                obj.UpdateEmployee(id, "Phone");
                                flag = true;
                                break;
                            case 3:
                                obj.UpdateEmployee(id, "Email");
                                flag = true;
                                break;
                            case 4:
                                obj.UpdateEmployee(id, "Role");
                                flag = true;
                                break;
                            case 5:
                                Console.WriteLine("Enter Department Name");
                                string dept_name = Console.ReadLine();
                                obj.UpdateEmpDept(id, dept_name);
                                flag = true;
                                break;
                            case 6:
                                flag = false;
                                break;

                            default:
                                Console.WriteLine("Wrong Choice..Please Enter Again");
                                flag = true;
                                break;

                        }


                    } while (flag);
                }
                else if (spec == false)
                {
                    //throw new Exception("Invalid Id");
                }
                else
                {
                    throw new Exception("Error Occured");
                }
            }
            catch(InvalidCastException)
            {
                Console.WriteLine("The Id should be of type integer");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ShowData()
        {
            obj.ShowDetails();
        }

        public void ShowSpecificData()
        {
            try
            {
                Console.WriteLine("Enter Id for Specific Data");
                int id = int.Parse(Console.ReadLine());
                bool? update = obj.ShowSpecifcDetails(id);
                if (update==true)
                {

                }
                else if(update == false)
                {

                }
                else
                {
                    throw new Exception("Error Occured");
                }
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeleteData()
        {
            try
            {
                Console.WriteLine("Enter Id for Specific Data");
                int id = int.Parse(Console.ReadLine());
                if (obj.DeleteEmployee(id))
                {
                    Console.WriteLine("Data Deleted Successfully");
                }
                else
                {
                    throw new Exception("Error Occured");
                }
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
