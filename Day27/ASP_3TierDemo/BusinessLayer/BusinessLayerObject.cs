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
    public class BusinessLayerObject
    {
        DataAccessObject _dataAccessObject = new DataAccessObject();
        public void Insert(Student std)
        {
            try
            {
                //_dataAccessObject.InsertDataQuery(std);
                //_dataAccessObject.InsertDataProcedure(std);
                _dataAccessObject.InsertusingDatatableWizard(std);
            }
            catch
            {
                throw;
            }
        }

        public object Getdata()
        {
            return _dataAccessObject.SelectData();
        }

        //public void Update(Student std,int rowindex)
        //{
        //    DataTable dt = (DataTable)Getdata();
        //    DataRow dr = dt.Rows[rowindex];
        //    dr["First_Name"]
        //}
    }
}
