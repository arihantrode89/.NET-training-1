using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspWebFormsDemo
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnCalendarChange(object sender,EventArgs e)
        {
            ListBox1.Items.Add(Calendar1.SelectedDate.ToString());
        }

        protected void ClearList(object sender,EventArgs e)
        {
            ListBox1.Items.Clear();
        }
    }
}