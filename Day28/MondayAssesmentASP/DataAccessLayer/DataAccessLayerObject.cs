using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entity;


namespace DataAccessLayer
{
    public class DataAccessLayerObject
    {
        public static string ConnStr = "Data Source=BLR1-LHP-N80812;Initial Catalog = training; Integrated Security = true";
        SqlConnection conn = new SqlConnection(ConnStr);
        public int InsertData(BookClass book)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("InsertBookData", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookId", book.BookId);
                cmd.Parameters.AddWithValue("@BookName", book.BookName);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@Publisher", book.Publisher);
                cmd.Parameters.AddWithValue("@Price", book.Price);
                int count = cmd.ExecuteNonQuery();
                return count;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public object GetData()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SelectBookData", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public int UpdateData(BookClass book)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand("UpdateBookData", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookId", book.BookId);
                cmd.Parameters.AddWithValue("@BookName", book.BookName);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@Publisher", book.Publisher);
                cmd.Parameters.AddWithValue("@Price", book.Price);
                int count = cmd.ExecuteNonQuery();
                return count;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        public int DeleteData(int bookid)
        {
            try
            {
                conn.Open();
                var query = new SqlCommand("DeleteBookData", conn);
                query.CommandType = CommandType.StoredProcedure;
                query.Parameters.AddWithValue("@BookId", bookid);
                int count = query.ExecuteNonQuery();
                return count;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
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
