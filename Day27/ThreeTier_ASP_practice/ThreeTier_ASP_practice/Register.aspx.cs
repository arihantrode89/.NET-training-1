using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using BusinessLayer;
using System.Data.SqlClient;
using System.Data;
namespace ThreeTier_ASP_practice
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        public void BindData()
        {
            try
            {
                EmployeeBusinessLogic obj = new EmployeeBusinessLogic();
                var datasource = obj.ShowData();
                if (datasource != null)
                {
                    GridView1.DataSource = datasource;
                    GridView1.DataBind();
                }
                else
                {
                    GridView1.DataSource = null;
                    Response.Write("No Data Present");
                }

            }
            catch
            {
                Response.Write("Error Occured");
            }
        }
        protected void AddEmployeeData(object sender,EventArgs e)
        {
            EmployeeBusinessLogic obj = new EmployeeBusinessLogic();
            try
            {
                Employee emp = new Employee(Name.Text, phone.Text, email.Text, role.Text, dob.Text, gender.SelectedValue[0]);
                obj.InsertData(emp);
                BindData();
            }
            catch(SqlException ex)
            {
                Response.Write(ex.Message);
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                Name.Text = "";
                phone.Text = "";
                email.Text = "";
                role.Text = "";
                dob.Text = "";
                gender.SelectedIndex = -1;
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            EmployeeBusinessLogic obj = new EmployeeBusinessLogic();
            try
            {
                Employee emp = new Employee();
                emp.Name = e.NewValues["Name"].ToString();
                emp.Phone = e.NewValues["Phone"].ToString();
                emp.Email = e.NewValues["Email"].ToString();
                emp.Role = e.NewValues["Role"].ToString();
                emp.DateofBirth = e.NewValues["Dob"].ToString();
                emp.Gender = e.NewValues["Gender"].ToString()[0];
                obj.UpdateData(emp,e.RowIndex);
            }
            catch(SqlException ex)
            {
                Response.Write(ex.Message);
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                GridView1.EditIndex = -1;
                BindData();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindData();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                EmployeeBusinessLogic obj = new EmployeeBusinessLogic();
                obj.DeleteData(e.RowIndex);
            }
            catch(SqlException ex)
            {
                Response.Write(ex.Message);
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                BindData();
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            e.Cancel = true;
            GridView1.EditIndex = -1;
            BindData();
        }
    }
}