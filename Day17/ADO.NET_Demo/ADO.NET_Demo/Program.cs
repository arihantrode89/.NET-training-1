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
                "Data Source = (BLR1-LHP-N80812);Initial Catalog=training;");

            SqlDataReader reader = null;
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select Name,Email,Role from Employee",conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(0));
                }
            }
            finally
            {
                conn.Close();
                reader.Close();
            }
        }
    }
}
