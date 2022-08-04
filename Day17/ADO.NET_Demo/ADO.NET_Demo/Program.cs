using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.NET_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection(
                "Data Source=BLR1-LHP-N80812;Initial Catalog=training;Integrated Security=true;");

            SqlDataReader reader = null;
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select Name,Email,Role from Employee order by Id",conn);

                reader = cmd.ExecuteReader();
             
                List<Dictionary<string,string>> obj = new List<Dictionary<string,string>>();
                while (reader.Read())
                {
                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        //Console.WriteLine(reader[i]);

                        obj.Add(new Dictionary<string, string> { { reader.GetName(i),reader.GetString(i) } });
                    }
                    
                    //Console.WriteLine(reader.GetString(0)+reader.GetString(1)+reader.GetString(2));
                    
                }
                foreach(var item in obj)
                {
                    foreach(KeyValuePair<string,string> dict in item)
                    {
                        Console.WriteLine($"{dict.Key}:{dict.Value}");
                    }
                    
                }
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
