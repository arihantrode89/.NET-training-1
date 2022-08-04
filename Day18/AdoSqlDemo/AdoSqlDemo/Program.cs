using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace AdoSqlDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection
                    ("Data Source = BLR1-LHP-N80812;Initial Catalog=training;Integrated Security=true;");
            SqlDataReader reader = null;
           
            try
            {

                conn.Open();
                SqlCommand query = new SqlCommand("Select * from Employee where Name=@Name",conn);

                SqlParameter param = new SqlParameter();
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                param.ParameterName = "@Name";
                param.Value = name;

                query.Parameters.Add(param);
                reader = query.ExecuteReader();

                while (reader.Read())
                {
                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)}:{reader[i]}");
                        
                    }
                    Console.WriteLine("".PadLeft(30,'-'));
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
                if(conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
