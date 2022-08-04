using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADO_Sql_ProcedureDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Simple procedure
            //SimpleProcedure();

            ParamterProcedure();
        }

        public static void SimpleProcedure()
        {
            SqlConnection conn = new SqlConnection(
                "Data Source = BLR1-LHP-N80812;Initial Catalog=training;Integrated Security=true");

            SqlDataReader reader = null;
            try
            {
                conn.Open();

                SqlCommand query = new SqlCommand("Sp_Get_Employees", conn);

                query.CommandType = CommandType.StoredProcedure;

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

        public static void ParamterProcedure()
        {
            SqlConnection conn = new SqlConnection(
                "Data Source = BLR1-LHP-N80812;Initial Catalog=training;Integrated Security=true");

            SqlDataReader reader = null;

            try
            {
                conn.Open();
                SqlCommand query = new SqlCommand("GetEmpByGenderAndDept", conn);

                query.CommandType = CommandType.StoredProcedure;

                query.Parameters.Add(new SqlParameter("@Gender",'M'));
                query.Parameters.Add(new SqlParameter("@DeptiD", 100));

                reader = query.ExecuteReader();

                while (reader.Read())
                {
                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine($"{reader.GetName(i)}:{reader[i]}");
                    }
                    Console.WriteLine("".PadLeft(30, '-'));
                }
            }
            finally
            {
                if(reader!= null)
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
