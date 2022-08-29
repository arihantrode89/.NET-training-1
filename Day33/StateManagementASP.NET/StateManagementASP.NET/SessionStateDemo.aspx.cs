using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementASP.NET
{
    public partial class SessionStateDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["user"] = "Arihant";
            Session.Timeout = 10;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Session.Count; i++)
            {
                Response.Write(Session[i]);
            }
        }
    }
}