using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace ADO_DML_Demo
{
    internal class Program
    {
        SqlConnection conn;
        public Program()
        {
            conn = new SqlConnection(
                "Data Source =BLR1-LHP-N80812 ;Initial Catalog=training;Integrated Security=true;");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();

            Console.WriteLine("Before Insert");
            Console.WriteLine("".PadLeft(30,'-'));
            obj.ReadData();

            Console.WriteLine($"Count is {obj.CountRow()}");

            obj.InsertData();

            Console.WriteLine("After Insert");
            Console.WriteLine("".PadLeft(30, '-'));

            obj.ReadData();

            Console.WriteLine($"Count is {obj.CountRow()}");

            obj.UpdateData();

            Console.WriteLine("After Update");
            Console.WriteLine("".PadLeft(30, '-'));

            obj.ReadData();

            Console.WriteLine($"Count is {obj.CountRow()}");

            obj.DeleteData();

            Console.WriteLine("After Delete");
            Console.WriteLine("".PadLeft(30, '-'));

            obj.ReadData();

            Console.WriteLine($"Count is {obj.CountRow()}");

        }

        public  void ReadData()
        {
            conn.Open();
            SqlDataReader reader = null;
            try
            {
                SqlCommand query = new SqlCommand("Select dept_name from Department", conn);

                reader = query.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(0));
                }
                Console.WriteLine("".PadLeft(30, '-'));
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

        public  void InsertData()
        {
            conn.Open();

            SqlDataReader reader = null;
            try
            {
                SqlCommand query = new SqlCommand("Insert into Department values('Maths','Kanpur')", conn);

                query.ExecuteNonQuery();

                Console.WriteLine("".PadLeft(30, '-'));
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

        public void UpdateData()
        {
            conn.Open();

            SqlDataReader reader = null;
            try
            {
                SqlCommand query = new SqlCommand("Update Department set dept_name='Mathematics' where dept_name = 'Maths'", conn);

                query.ExecuteNonQuery();

                Console.WriteLine("".PadLeft(30, '-'));
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

        public void DeleteData()
        {
            conn.Open();

            SqlDataReader reader = null;
            try
            {
                SqlCommand query = new SqlCommand("Delete from Department where dept_name = 'Mathematics'", conn);

                query.ExecuteNonQuery();

                Console.WriteLine("".PadLeft(30, '-'));
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

        public int CountRow()
        {
            conn.Open();

            SqlDataReader reader = null;
            int count =-1;
            try
            {
                SqlCommand query = new SqlCommand("Select count(*) from Department", conn);

                count = (int)query.ExecuteScalar();

                Console.WriteLine("".PadLeft(30, '-'));
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
            return count;
        }
    }
}
