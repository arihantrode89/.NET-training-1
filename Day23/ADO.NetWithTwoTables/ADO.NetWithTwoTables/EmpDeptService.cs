using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.NetWithTwoTables
{
    internal class EmpDeptService:IEmpdept
    {
        SqlConnection conn = new SqlConnection("Data Source = BLR1-LHP-N80812;Initial Catalog=training;Integrated Security=true");

        public void AddEmployee(int Id, string Name,long Phone,string Email,string Role,string Dob,char Gender,char Band,string Grade,float Sal,string Doj,string Dept)
        {
            conn.Open();
            try
            {
                string dept = $"Select dept_no from Department where dept_name='{Dept}'";
                SqlCommand query = new SqlCommand(dept,conn);
                int Dept_no = (int)query.ExecuteScalar();
                if(Dept_no > 0)
                {
                    string str = $"Insert into Employee values('{Id}','{Name}','{Phone}','{Email}','{Role}','{Dob}','{Gender}','{Band}','{Grade}','{Sal}','{Doj}','{Dept_no}')";
                    SqlCommand cmd1 = new SqlCommand(str,conn);
                    cmd1.ExecuteNonQuery();
                }
                else
                {
                    throw new EmpDeptExceptions();
                }               
            }
            catch(EmpDeptExceptions e)
            {
                e.InvalidDept();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(conn!= null)
                {
                    conn.Close();
                }
            }
        }

        public bool DeleteDetails(int id)
        {
            conn.Open();
            try
            {
                string query = $"Delete from Employee where Id ={id}";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void ShowDetails()
        {
            conn.Open();
            SqlDataReader reader = null;
            try
            {
                string empq = $"Select * from Employee as e inner join Department as d On e.dept_no = d.dept_no";
                SqlCommand query = new SqlCommand(empq, conn);
                reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.WriteLine($"{reader[i]}");
                        }
                        Console.WriteLine("".PadLeft(30, '-'));
                    }
                    
                }
                else
                {
                    throw new EmpDeptExceptions();
                }
            }
            catch (EmpDeptExceptions e)
            {
                e.InvalidDept();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public bool ShowSpecificDetails(int id)
        {
            conn.Open();
            SqlDataReader reader = null;
            try
            {
                string query = $"Select * from Employee inner join Department on Employee.dept_no=Department.dept_no where Id ={id};";
                SqlCommand cmd = new SqlCommand(query,conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {

                            Console.WriteLine($"{reader[i]}");
                        }
                        Console.WriteLine("".PadLeft(30,'-'));
                    }
                    return true;
                }
                else
                {
                    throw new EmpDeptExceptions();
                }
            }
            catch(EmpDeptExceptions ex)
            {
                ex.EmptyDatabase();
                return false;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        
        public void Update(string col, int id)
        {
            Console.WriteLine($"Enter {col}:");
            string str = $"Update Employee set {col} = '{Console.ReadLine()}' where Id = {id}";
            SqlCommand query = new SqlCommand(str, conn);
            query.ExecuteNonQuery();
        }
        public bool UpdateEmployee(int id)
        {
            conn.Open();
            try
            {
                Console.WriteLine("Choose what you want to update\n" +
                        "1.Name\n2.Phone\n3.Email \n4.Role\n5.Salary\n6.Department\n7.Exit\n");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Update("Name", id);
                        return true;
                    case 2:
                        Update("Phone", id);
                        return true;
                    case 3:
                        Update("Email", id);
                        return true;
                    case 4:
                        Update("Role", id);
                        return true;
                    case 5:
                        Update("Salary", id);
                        return true;
                    case 6:
                        Console.WriteLine("Enter Department Name");
                        string dept_name = Console.ReadLine();
                        string deptquery = $"Select dept_no from Department where dept_name ='{dept_name}' ";
                        SqlCommand deptq = new SqlCommand(deptquery, conn);
                        int? dept_no = null;
                        dept_no =(int)deptq.ExecuteScalar();
                        if (dept_no != null)
                        {
                            string query = $"Update Employee Set dept_no={dept_no} where Id ={id};";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();

                        }
                        else
                        {
                            throw new EmpDeptExceptions();
                        }
                        //string query = $"Update Employee Set dept_no=(Select dept_no from Department where dept_name={dept_name}) where Id ={id};";
                        return true;

                    default:
                        Console.WriteLine("Wrong Choice");
                        return false;
                }

            }
            catch (EmpDeptExceptions e)
            {
                e.InvalidDept();
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
