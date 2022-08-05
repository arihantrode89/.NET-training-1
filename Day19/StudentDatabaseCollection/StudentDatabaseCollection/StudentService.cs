using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
namespace StudentUsingDatabase
{
    internal class StudentService:IStudent
    {
        List<Dictionary<string, string>> obj = new List<Dictionary<string, string>>();
        Boolean Added = false;
        string value;
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

                Dictionary<string, string> data = new Dictionary<string, string>();
                data.Add("Id", Convert.ToString(id));
                data.Add("Name", name);
                data.Add("Address", address);
                data.Add("Obtained_Marks", Convert.ToString(ObtainedMarks));
                data.Add("Total_Marks", Convert.ToString(Totalmarks));
                obj.Add(data);
                Added = true;


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

        public void Update(string col,int id)
        {
            Console.WriteLine($"Enter {col}:");
            value = Console.ReadLine();
            string str = $"Update StudentDetails set {col} = '{value}' where Id = {id}";
            SqlCommand query = new SqlCommand(str, conn);
            query.ExecuteNonQuery();
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
                        Update("Name", id);
                        foreach(var item in obj)
                        {
                            if (item["Id"] == Convert.ToString(id))
                            {
                                item["Name"] = Convert.ToString(value);
                                break;

                            }
                        }
                        Added = true;
                        return true;
                        


                    case 2:
                        Update("Address", id);

                        foreach (var item in obj)
                        {
                            if (item["Id"] == Convert.ToString(id))
                            {
                                item["Address"] = Convert.ToString(value);
                                break;

                            }
                        }
                        Added = true;
                        return true;
                    case 3:
                        Update("Obtained_Marks", id);

                        foreach (var item in obj)
                        {
                            if (item["Id"] == Convert.ToString(id))
                            {
                                item["Obtained_Marks"] = Convert.ToString(value);
                                break;

                            }
                        }
                        Added = true;
                        return true;
                    case 4:
                        Update("Total_Marks", id);

                        foreach (var item in obj)
                        {
                            if (item["Id"] == Convert.ToString(id))
                            {
                                item["Total_Marks"] = Convert.ToString(value);
                                break;

                            }
                        }
                        Added = true;
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

                foreach(var item in obj)
                {
                    if (item["Id"] == Convert.ToString(id))
                    {
                        obj.Remove(item);
                        return true;
                    }
                }

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

        public void ShowDetails()
        {
            conn.Open();
            SqlDataReader reader = null;
            try
            {
                if (Added == false)
                {
                    string str = $"Select * from StudentDetails";
                    SqlCommand query = new SqlCommand
                        (str, conn);

                    reader = query.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Dictionary<string, string> data = new Dictionary<string, string>();
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                data.Add(reader.GetName(i), Convert.ToString(reader[i]));
                            }
                            obj.Add(data);
                            data = new Dictionary<string, string>();
                        }
                    }
                    else
                    {
                        throw new ExceptionStudent();
                    }
                }

                if (obj.Count>0)
                {
                    foreach (var item in obj)
                    {
                        foreach (KeyValuePair<string, string> dt in item)
                        {
                            Console.WriteLine($"{dt.Key}: {dt.Value}");

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
                //string str = $"Select * from StudentDetails where Id = {id}";
                //SqlCommand query = new SqlCommand
                //    (str, conn);

                //reader = query.ExecuteReader();
                //if (reader.HasRows)
                //{

                //    while (reader.Read())
                //    {
                //        for (int i = 0; i < reader.FieldCount; i++)
                //        {
                //            Console.WriteLine($"{reader.GetName(i)}: {reader[i]}");
                //        }
                //        Console.WriteLine("".PadLeft(30, '-'));
                //    }
                    
                //    return true;
                //}
                //else
                //{
                //    throw new ExceptionStudent();
                //}
                foreach(var item in obj)
                {
                    if (item["Id"] == Convert.ToString(id))
                    {
                        foreach (KeyValuePair<string, string> dt in item)
                        {
                            Console.WriteLine($"{dt.Key}: {dt.Value}");
                        }
                        return true;
                    }
                    
                }

                throw new ExceptionStudent();

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
