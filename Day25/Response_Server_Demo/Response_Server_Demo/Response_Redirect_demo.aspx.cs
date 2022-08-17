using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Response_Server_Demo
{
    public partial class Response_Redirect_demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Response_Redirect_same(object sender,EventArgs e)
        {
            Response.Redirect("SecondPage.aspx");
        }

        protected void Server_Transfer_same(object sender, EventArgs e)
        {
            Server.Transfer("SecondPage.aspx");
        }

        protected void Response_Redirect_diffrent(object sender, EventArgs e)
        {
            Response.Redirect("https://www.google.com/");
        }

        protected void Server_Transfer_diffrent(object sender, EventArgs e)
        {
            Server.Transfer("https://www.google.com/");
        }
    }
}