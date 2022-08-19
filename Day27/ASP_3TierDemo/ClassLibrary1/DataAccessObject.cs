using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Entity;
using System.Data;

namespace DataAccessLayer
{
    public class DataAccessObject
    {

        public SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ForumSite;Integrated Security=True");

        User_Dataset.SelectUserDataTable user_dt = new User_Dataset.SelectUserDataTable();
        User_DatasetTableAdapters.SelectUserTableAdapter adapter = new User_DatasetTableAdapters.SelectUserTableAdapter();

        public void InsertDataQuery(Student std)
        {
            conn.Open();
            string FirstName = std.FirstName;
            string LastName = std.LastName;
            string Email = std.Email;
            string Mobile = std.Phone;
            string pass = std.Password;

            string query = $"Insert into Users(First_Name,Last_Name,Email,Mobile) values('{FirstName}','{LastName}','{Email}','{Mobile}')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                string query1 = $"Select Id from Users where Email='{Email}' ";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                int id = (int)cmd1.ExecuteScalar();

                string passquery = $"Insert into User_Password values('{pass}','{id}')";
                SqlCommand passcmd = new SqlCommand(passquery, conn);
                passcmd.ExecuteNonQuery();

            }

        }

        public void InsertDataProcedure(Student std)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("InsertUser", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("firstname", std.FirstName);
                cmd.Parameters.AddWithValue("lastname", std.LastName);
                cmd.Parameters.AddWithValue("Email", std.Email);
                cmd.Parameters.AddWithValue("Mobile", std.Phone);
                cmd.Parameters.AddWithValue("Password", std.Password);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }

        }

        public void InsertusingDatatableWizard(Student std)
        {
            adapter.Insert(std.FirstName, std.LastName, std.Email, std.Phone, std.Password);
        }

        public object SelectData()
        {
            return user_dt = adapter.GetUserData();
        }
    }
    }
