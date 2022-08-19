using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccessLayer;

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
                _dataAccessObject.InsertDataProcedure(std);
            }
            catch
            {
                throw;
            }
        }
    }
}
