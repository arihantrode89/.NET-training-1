using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using Entity;
using System.Data.SqlClient;

namespace MondayAssesmentASP
{
    public partial class BookDetails : System.Web.UI.Page
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
                BusinessLayerObject obj = new BusinessLayerObject();
                var datasource = obj.ShowData();
                if (datasource != null)
                {
                    GridView1.DataSource = datasource;
                    GridView1.DataBind();
                }
                else
                {
                    GridView1.DataSource = null;
                    GridView1.DataBind();
                    throw new BookException();
                }

            }
            catch(BookException ex)
            {
                GridView1.DataSource = null;
                Response.Write(ex.EmptyDatabase());
            }
            catch
            {
                Response.Write("Error Occured");
            }
        }

        protected void AddBookDetails(object sender, EventArgs e)
        {
            BusinessLayerObject obj = new BusinessLayerObject();
            try
            {
                BookClass book = new BookClass(Convert.ToInt32(BookId.Text), BookName.Text, Author.Text, Publisher.Text, float.Parse(Price.Text));
                bool insert = obj.InsertData(book);
                if (insert)
                {
                    BindData();
                }
                else
                {
                    throw new BookException();
                }
            }
            catch(BookException ex)
            {
                Response.Write(ex.OperationError("Insertion"));
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                BookId.Text = "";
                BookName.Text = "";
                Author.Text = "";
                Publisher.Text = "";
                Price.Text = "";
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            BusinessLayerObject obj = new BusinessLayerObject();
            try
            {
                BookClass emp = new BookClass();
                emp.BookId =    Convert.ToInt32(e.NewValues["BookId"].ToString());
                emp.BookName = e.NewValues["BookName"].ToString();
                emp.Author = e.NewValues["Author"].ToString();
                emp.Publisher = e.NewValues["Publisher"].ToString();
                emp.Price = float.Parse(e.NewValues["Price"].ToString());
                
                bool update = obj.UpdateData(emp);
                if (update)
                {
                    BindData();
                }
                else
                {
                    throw new BookException();
                }
            }
            catch(BookException ex)
            {
                Response.Write(ex.OperationError("Updation"));
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                GridView1.EditIndex = -1;
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
                BusinessLayerObject obj = new BusinessLayerObject();
                var del = obj.DeleteData(Convert.ToInt32(e.Values["BookId"].ToString()));
                if (del)
                {
                    BindData();
                }
                else
                {
                    throw new BookException();
                }
            }
            catch (BookException ex)
            {
                Response.Write(ex.OperationError("Deletion"));
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
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