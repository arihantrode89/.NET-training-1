using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace MondayAssesmentASP
{
    public class BookException:ApplicationException
    {
        public string EmptyDatabase()
        {
            return "Book Details Database is Empty";
        }
        public string OperationError(string str)
        {
            return $"{str} Error Occured";
        }

    }
}