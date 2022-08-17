using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace Asp.NET
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        public dynamic Connection()
        {
            string str = ConfigurationManager.ConnectionStrings["login"].ToString();
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            return conn;

        }

        protected void Loginbtn_click(object sender, EventArgs e)
        {
            var conn = Connection();
            try
            {
                string username = emailid.Text;
                string pass = password.Text;
                string query = $"Select Id from Users where Email='{username}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                int? Id;
                Id = (int)cmd.ExecuteScalar();
                if (Id != null)
                {
                    string querypass = $"Select Password from User_Password where User_id={Id}";
                    SqlCommand cmdpass = new SqlCommand(querypass, conn);
                    string pwd = null;
                    pwd = (string)cmdpass.ExecuteScalar();
                    if (pwd != null)
                    {
                        if (pwd == pass)
                        {
                            Response.Output.Write($"Welcome to Forum Site");
                            emailid.Text = "";
                            password.Text = "";

                        }
                        else
                        {

                            Response.Output.Write($"Invalid Credentials");
                            emailid.Text = "";
                            password.Text = "";

                        }
                    }

                }

            }
            catch(Exception ex)
            {
                Response.Output.Write(ex.Message);
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