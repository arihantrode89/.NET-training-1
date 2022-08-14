using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
namespace DataAccessLayers
{
    public class EmployeeDepartmentDataAccessLayer
    {
        SqlConnection conn = new SqlConnection("Data Source=BLR1-LHP-N80812;Initial Catalog=training;Integrated Security=true;");
        public void InsertEmployeeData(Employee e,string dept_name)
        {
            conn.Open();
            try
            {
                string deptquery = $"Select dept_no from Department where dept_name='{dept_name}'";
                SqlCommand deptcmd = new SqlCommand(deptquery, conn);
                int? dept_no = null;
                dept_no =(int)deptcmd.ExecuteScalar();
                if (dept_no != null)
                {
                    string query = $"Insert into Employee(Name,Phone,Email,Role,Dob,Gender,dept_no) values('{e.Name}',{e.Phone}',{e.Email}',{e.Role}',{e.Dob}',{e.Gender}')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        Console.WriteLine("Data Inserted Successfully");
                    }
                    else
                    {
                        throw new Exception("Insertion Operation Failed");
                    }
                }
                else
                {
                    throw new EmployeeDepartmentException();
                }
                
            }
            catch(EmployeeDepartmentException ex)
            {
                ex.InvalidDepartment();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                }
            }
        }

        public bool UpdateEmployeeData(int id,string col)
        {
            conn.Open();
            try
            {
                Console.WriteLine($"Enter {col}:");
                string query = $"Update Employee set {col}='{Console.ReadLine()}' where Id={id}";
                SqlCommand cmd = new SqlCommand(query, conn);
                int count = cmd.ExecuteNonQuery();
                if(count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                if( conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void UpdateEmployeeDept(string dept_name, int id)
        {
            conn.Open();
            try
            {
                //string query = $"Update Employee Set dept_no=(Select dept_no from Department where dept_name={dept_name}) where Id ={id};";
                string deptquery = $"Select dept_no from Department where dept_name ='{dept_name}' ";
                SqlCommand deptq = new SqlCommand(deptquery, conn);
                int? dept_no = null;
                dept_no = (int)deptq.ExecuteScalar();
                if (dept_no != null)
                {
                    string query = $"Update Employee Set dept_no={dept_no} where Id ={id};";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                }
                else
                {
                    throw new EmployeeDepartmentException();
                }
            }
            catch(EmployeeDepartmentException e)
            {
                e.InvalidDepartment();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                }
            }
        }
        public bool DeleteEmployeeData(int id)
        {
            conn.Open();
            try
            {
                string query = $"Delete from Employee Where Id={id}";
                SqlCommand cmd = new SqlCommand(query,conn);
                int count = cmd.ExecuteNonQuery();
                if(count > 0)
                {
                    return true;
                }
                else
                {
                    return false ;
                }

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
                string query = $"Select e.Id, e.Name,e.Phone,e.Email,e.Role,e.Dob,e.Gender,d.dept_name,d.dept_no from Employee e inner join Department d on e.dept_no=d.dept_no";
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for(int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.WriteLine($"{reader.GetName(i)}: {reader.GetValue(i)}");
                        }
                        Console.WriteLine("".PadLeft(30,'-'));
                    }
                }
                else
                {
                    throw new EmployeeDepartmentException();
                }
            }
            catch(EmployeeDepartmentException e)
            {
                e.EmptyDatabase();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if(conn != null)
                {
                    conn.Close();
                }
            }
        }

        public bool? ShowSpecificEmployeeDetails(int id)
        {
            conn.Open();
            SqlDataReader reader = null;
            try
            {
                string query = $"Select e.Name,e.Phone,e.Email,e.Role,e.Dob,e.Gender,d.dept_name,d.dept_no from Employee e inner join Department d on e.dept_no = d.dept_no where e.Id={id};";
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.WriteLine($"{reader.GetName(i)}: {reader.GetValue(i)}");
                        }
                        Console.WriteLine("".PadLeft(30, '-'));
                    }
                    return true;
                }
                else
                {
                    throw new EmployeeDepartmentException();
                    
                }
            }
            catch (EmployeeDepartmentException e)
            {
                e.InvalidId();
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
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
    }
}
