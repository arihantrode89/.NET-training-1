using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace ObjectDataSource_ControlsDemo
{
    public partial class StudentGridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            del_label.Visible = false;
        }

        protected void AddStudent(object sender,EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["trainingConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            try
            {

                string query = $"Insert into StudentGridView values('{Name.Text}','{email.Text}','{Phone.Text}','{dept.Text}')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                Name.Text = "";
                email.Text = "";
                Phone.Text = "";
                dept.Text = "";
                Response.Redirect("StudentGridView.aspx");

            }
            catch(SqlException sql)
            {
                Response.Write(sql.Message);
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        protected void DeleteStudent(object sender,EventArgs e)
        {
            if (gridview1.SelectedRow != null)
            {
                
                string str = ConfigurationManager.ConnectionStrings["trainingConnectionString"].ToString();
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                try
                {

                    string query = $"Delete from StudentGridView where Id={(int)gridview1.SelectedValue}";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    Response.Redirect("StudentGridView.aspx");


                }
                catch (SqlException sql)
                {
                    Response.Write(sql.Message);
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                
                del_label.Visible = true;
                del_label.Text = "Please Select the row from grid view";
            }
        }

        protected void gridview1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            if (e.Exception == null)
            {
                del_label.Visible = true;
                del_label.Text = "Deleted Successfully";
            }
        }
    }
}