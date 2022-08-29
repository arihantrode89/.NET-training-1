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
            Response.Cookies["Name"].Value = TextBox1.Text;
            Response.Cookies["Name"].Expires = DateTime.Now.AddMinutes(1);
            Label1.Text = "Cookie Created";
            TextBox1.Text = " ";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Response.Cookies["Name"] != null)
            {
                TextBox2.Text = Response.Cookies["Name"].Value;
            }
            else
            {
                TextBox2.Text = "No Cookie Found";
            }
        }
    }
}