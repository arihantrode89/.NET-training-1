using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class BookClass
    {
        int _bookid;
        string _bookname, _author, _publisher;
        float _price;

        public BookClass()
        {

        }

        public BookClass(int bookid, string bookname, string author, string publisher, float price)
        {
            BookId = bookid;
            BookName = bookname;
            Author = author;
            Publisher = publisher;
            Price = price;
        }

        public int BookId { get { return _bookid; } set{ _bookid = value; } }
        public string BookName { get { return _bookname; } set { _bookname = value; } }
        public string Author { get { return _author; } set{ _author = value; } }
        public string Publisher { get { return _publisher; } set{ _publisher = value; } }
        public float Price { get { return _price; } set { _price = value; } }

    }
}
