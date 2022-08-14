using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace LoginAsp
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source = BLR1-LHP-N80812;Initial Catalog=ForumSite;Integrated Security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Signup_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string FirstName = firstname.Text;
                string LastName = lastname.Text;
                string Email = email.Text;
                string Mobile = phone.Text;
                string pass = password.Text;
                string cnfpass = cnf_password.Text;

                if(pass == cnfpass)
                {
                    string query = $"Insert into Users(First_Name,Last_Name,Email,Mobile) values('{FirstName}','{LastName}','{Email}','{Mobile}')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int count = cmd.ExecuteNonQuery();
                    if(count > 0)
                    {
                        string query1 = $"Select Id from Users where Email='{Email}' ";
                        SqlCommand cmd1 = new SqlCommand(query1, conn);
                        int id = (int)cmd1.ExecuteScalar();

                        string passquery = $"Insert into User_Password values('{pass}','{id}')";
                        SqlCommand passcmd = new SqlCommand(passquery, conn);
                        passcmd.ExecuteNonQuery();

                    }
                }
                else
                {
                    
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
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