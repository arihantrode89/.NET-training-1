using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginAsp
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source = BLR1-LHP-N80812;Initial Catalog=ForumSite;Integrated Security=true");

        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Loginbtn_click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string username = emailid.Text;
                string pass = password.Text;
                string query = $"Select Id from Users where Email='{username}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                int? Id;
                Id = (int)cmd.ExecuteScalar();
                if (Id!=null)
                {
                    string querypass = $"Select Password from User_Password where User_id={Id}";
                    SqlCommand cmdpass = new SqlCommand(querypass, conn);
                    string pwd = null;
                    pwd = (string)cmdpass.ExecuteScalar();
                    if (pwd != null)
                    {
                        if(pwd == pass)
                        {
                            Response.Output.Write($"Welcome to Forum Site");
                            emailid.Text = "";
                            password.Text = "";
                            
                        }
                        else
                        {
                            
                            Response.Output.Write($"Invalid Credentials");
                        }
                    }

                }

            }
            catch
            {

            }
        }
    }
}