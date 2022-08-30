using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementASP.NET
{
    public partial class CookiesDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Cookies["name"].Value = TextBox1.Text;
            Response.Cookies["name"].Expires = DateTime.Now.AddMinutes(20);
            Label1.Text = "Cookie Created";
            TextBox1.Text = " ";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Response.Cookies["name"].Values == null)
            {
                TextBox2.Text = "No Cookie Found";
            }
            else
            {
                TextBox2.Text = Response.Cookies["name"].Value;
            }
        }
    }
}