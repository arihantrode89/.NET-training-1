using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq_AspDemo
{
    public partial class LinqAspDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var selitems = from ListItem item in ListLinq.Items where item.Selected==true select item;

            foreach(var item in selitems)
            {
                Response.Write(item.Text+ "<br/>");
            }
        }


    }
}