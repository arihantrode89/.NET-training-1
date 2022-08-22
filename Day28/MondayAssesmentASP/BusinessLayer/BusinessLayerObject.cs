using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BusinessLayerObject:IBookDetails
    {
        DataAccessLayerObject obj = new DataAccessLayerObject();

        public bool InsertData(BookClass book)
        {
            try
            {
                int count = obj.InsertData(book);
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public object ShowData()
        {
            try
            {
                var data = (DataTable)obj.GetData();
                if (data.Rows.Count > 0)
                {
                    return data;
                }
                else
                {
                    return null;
                }
            }
            catch(SqlException)
            {
                throw;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public bool UpdateData(BookClass book)
        {
            try
            {
                int count = obj.UpdateData(book);
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteData(int bookid)
        {
            try
            {
                int count = obj.DeleteData(bookid);
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
