using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DisconnectedArchitecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection(
                "Data Source=BLR1-LHP-N80812;Initial Catalog=training;Integrated Security=true;");

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from Employee_Table",conn);
                SqlDataAdapter da1 = new SqlDataAdapter("Select * from Department", conn);


                DataTable dt = new DataTable();

                da.Fill(dt);

                foreach(DataRow row in dt.Rows)
                {
                    Console.WriteLine(row["EName"]);
                }

                Console.WriteLine("".PadLeft(30, '-'));

                DataSet ds = new DataSet();

                da.Fill(ds,"Employee_Table");
                da1.Fill(ds, "Department");

                Console.WriteLine(ds.Tables.Count);
                Console.WriteLine(ds.Tables[0].TableName);

                foreach(DataRow row in ds.Tables["Employee_Table"].Rows)
                {
                    foreach (DataColumn col in ds.Tables["Employee_Table"].Columns)
                    {
                        Console.WriteLine($"{col.ColumnName}:{ row[col]}");
                    }
                    Console.WriteLine("".PadLeft(30,'-'));
                }

                foreach (DataRow row in ds.Tables["Department"].Rows)
                {
                    foreach (DataColumn col in ds.Tables["Department"].Columns)
                    {
                        Console.WriteLine($"{col.ColumnName}:{row[col]}");
                    }
                    Console.WriteLine("".PadLeft(30, '-'));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
