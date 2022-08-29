using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementASP.NET
{
    public partial class ViewStateDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ViewState["Name"] = TextBox1.Text;
            TextBox1.Text = " ";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Visible = true;
            Label2.Text = ViewState["Name"].ToString();
        }
    }
}