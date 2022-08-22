using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace BusinessLayer
{
    internal interface IBookDetails
    {
        bool InsertData(BookClass book);
        object ShowData();
        bool UpdateData(BookClass book);
        bool DeleteData(int book);
    }
}
