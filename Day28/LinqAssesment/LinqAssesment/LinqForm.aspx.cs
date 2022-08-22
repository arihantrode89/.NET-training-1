using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqAssesment
{
    public partial class LinqForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            var items = from ListItem item in ListBox1.Items where item.Selected == true select item.Text;
            var items1 = from ListItem item in ListBox2.Items where item.Selected == true select item.Text;
            items.Union(items1);
            var merged = items.Union(items1);
            foreach (var a in merged) 
            {
                Response.Write(a);
            }



        }
    }
}