using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementASP.NET
{
    public partial class NextPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label1.Text = $"Welcome {Request.QueryString["name"]} {Request.QueryString["surname"]}";
            for(int i=0; i < Request.QueryString.Count; i++)
            {
                Response.Write(Request.QueryString[i]+"<br/>");
                
            }
        }
    }
}