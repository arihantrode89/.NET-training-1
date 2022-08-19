using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using Entity;
using System.Data;

namespace ASP_3TierDemo
{
    public partial class GridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SignupUser(object sender,EventArgs e)
        {
            BusinessLayerObject obj = new BusinessLayerObject();
            try
            {
                Student std = new Student();
                std.FirstName = firstname.Text;
                std.LastName = lastname.Text;
                std.Phone = phone.Text;
                std.Email = email.Text;
                std.Password = password.Text;

                obj.Insert(std);
                GridView1.DataSource = obj.Getdata();
                GridView1.DataBind();

                var aa = (DataTable)obj.Getdata();

            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                firstname.Text = "";
                lastname.Text = "";
                phone.Text = "";
                email.Text = "";
                password.Text = "";
                cnf_password.Text = "";
            }
        }
    }
}