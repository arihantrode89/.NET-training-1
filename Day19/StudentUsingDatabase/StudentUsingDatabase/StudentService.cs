using System.Data;
using System.Data.SqlClient;
using System;
namespace StudentUsingDatabase
{
    internal class StudentService:IStudent
    {
        SqlConnection conn = new SqlConnection(
            "Data Source = BLR1-LHP-N80812;Initial Catalog=training;Integrated Security=true");
        public void AddStudentDetails(int id, string name, string address, float Totalmarks, float ObtainedMarks)
        {
            conn.Open();
            try
            {
                string str = $"Insert into StudentDetails values('{id}','{name}','{address}','{ObtainedMarks}','{Totalmarks}')";
                SqlCommand query = new SqlCommand
                    (str, conn);

                query.ExecuteNonQuery();

            }
            catch(Exception e)
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

        public bool UpdateStudent(int id)
        {
            conn.Open();
            try
            {
                //DisplaySpecificDetail(id);
                Console.WriteLine("Choose what you want to update\n" +
                        "1.Name\n2.Address\n3.Obtained Marks\n4.Total Marks\n5.Exit\n");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Name:");
                        string str = $"Update StudentDetails set Name = '{Console.ReadLine()}' where Id = {id}";
                        SqlCommand query = new SqlCommand(str, conn);
                        query.ExecuteNonQuery();
                        return true;
                    case 2:
                        Console.WriteLine("Enter Address:");
                        string str1 = $"Update StudentDetails set Address = '{Console.ReadLine()}' where Id = {id}";
                        SqlCommand query1 = new SqlCommand(str1, conn);
                        query1.ExecuteNonQuery();
                        return true;
                    case 3:
                        Console.WriteLine("Enter Obtained Marsks:");
                        string str2 = $"Update StudentDetails set Obtained_Marks = {float.Parse(Console.ReadLine())} where Id = {id}";
                        SqlCommand query2 = new SqlCommand(str2, conn);
                        query2.ExecuteNonQuery();
                        return true;
                    case 4:
                        Console.WriteLine("Enter Total Marks:");
                        string str3 = $"Update StudentDetails set Total_Marks = {float.Parse(Console.ReadLine())} where Id = {id}";
                        SqlCommand query3 = new SqlCommand(str3, conn);
                        query3.ExecuteNonQuery();
                        return true;
                    default:
                        Console.WriteLine("Wrong Choice");
                        return false;
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

        public bool DeleteDetails(int id)
        {
            conn.Open();
            try
            {
                string str = $"Delete from StudentDetails where Id = {id}";
                SqlCommand query = new SqlCommand
                    (str, conn);

                query.ExecuteNonQuery();

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
                string str = $"Select * from StudentDetails";
                SqlCommand query = new SqlCommand
                    (str, conn);

                reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.WriteLine($"{reader.GetName(i)}: {reader[i]}");
                        }
                        Console.WriteLine("".PadLeft(30, '-'));
                    }
                }
                else
                {
                    throw new ExceptionStudent();
                }

            }
            catch(ExceptionStudent e)
            {
                e.EmptyDatabase();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }

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
                string str = $"Select * from StudentDetails where Id = {id}";
                SqlCommand query = new SqlCommand
                    (str, conn);

                reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.WriteLine($"{reader.GetName(i)}: {reader[i]}");
                        }
                        Console.WriteLine("".PadLeft(30, '-'));
                    }
                    return true;
                }
                else
                {
                    throw new ExceptionStudent();
                }

            }
            catch (ExceptionStudent e)
            {
                e.InvalidId();
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
    }
}
