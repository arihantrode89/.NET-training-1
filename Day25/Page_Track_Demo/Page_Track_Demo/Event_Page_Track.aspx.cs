using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Page_Track_Demo
{
    public partial class Event_Page_Track : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Log("Load");
        }

        protected override void OnPreRender(EventArgs e)
        {
            Log("Pre Render");
        }

        protected void ControlChanged(object sender,EventArgs e)
        {
            string str = ((Control)sender).ID;
            Log(str + " Changed");
        }

        protected void ClearListBox(object sender,EventArgs e)
        {
            ListBox1.Items.Clear();
            Text1.
        }
        public void Log(string str)
        {
            ListBox1.Items.Add(str);
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1;
           
        }
    }
}