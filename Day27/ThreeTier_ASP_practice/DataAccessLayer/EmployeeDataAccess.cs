using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Entity;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class EmployeeDataAccess
    {
        public static string ConnStr = "Data Source=BLR1-LHP-N80812;Initial Catalog = training; Integrated Security = true";
        SqlConnection conn = new SqlConnection(ConnStr);
        public void InsertData(Employee emp)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                
                DataSet ds = new DataSet();
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);

                var query = new SqlCommand("SelectEmp", conn);
                query.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = query;

                da.Fill(ds,"Employee");

                DataRow newrow = ds.Tables["Employee"].NewRow();
                newrow["Name"] = emp.Name;
                newrow["Phone"] = emp.Phone;
                newrow["Email"] = emp.Email;
                newrow["Dob"] = emp.DateofBirth;
                newrow["Role"] = emp.Role;
                newrow["Gender"] = emp.Gender;

                ds.Tables["Employee"].Rows.Add(newrow);

                cmd.GetInsertCommand();
                da.Update(ds,"Employee");

            }
            catch(SqlException ex)
            {
                throw;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public object GetData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SelectEmp",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void UpdateData(Employee emp,int rowindex)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            var query = new SqlCommand("SelectEmp", conn);
            query.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = query;
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            da.Fill(dt);

            DataRow updatedRow = dt.Rows[rowindex];
            updatedRow["Name"] = emp.Name;
            updatedRow["Phone"] = emp.Phone;
            updatedRow["Email"] = emp.Email;
            updatedRow["Role"] = emp.Role;
            updatedRow["Dob"] = emp.DateofBirth;
            updatedRow["Gender"] = emp.Gender;

            cmd.GetUpdateCommand();
            da.Update(dt);
        }

        public void DeleteData(int rowindex)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);

            var query = new SqlCommand("SelectEmp", conn);
            query.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = query;

            da.Fill(ds,"Employee");
            DataRow deleterow = ds.Tables["Employee"].Rows[rowindex];
            deleterow.Delete();

            cmd.GetDeleteCommand();
            da.Update(ds,"Employee");
        }
    }
}
