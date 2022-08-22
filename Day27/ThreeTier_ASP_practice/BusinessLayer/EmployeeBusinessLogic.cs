using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccessLayer;
using System.Data;


namespace BusinessLayer
{
    public class EmployeeBusinessLogic
    {
        EmployeeDataAccess obj = new EmployeeDataAccess();
        public void InsertData(Employee emp)
        {
            try
            {
                obj.InsertData(emp);
            }
            catch
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
                    throw new EmployeeException();
                }
            }
            catch(EmployeeException ex)
            {
                //customexception
                return null;
            }
            catch
            {
                throw;
            }
        }

        public void UpdateData(Employee emp,int rowindex)
        {
            try
            {
                obj.UpdateData(emp, rowindex);
            }
            catch
            {
                throw;
            }
        }

        public void DeleteData(int rowindex)
        {
            try
            {
                obj.DeleteData(rowindex);
            }
            catch
            {
                throw;
            }
        }
    }
}
