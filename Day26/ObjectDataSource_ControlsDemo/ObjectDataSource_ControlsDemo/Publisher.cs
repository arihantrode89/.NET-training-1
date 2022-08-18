using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObjectDataSource_ControlsDemo
{
    public class Publisher
    {
        List<Author> obj = new List<Author>();
        public List<Author> GetAuthorbyState(string state)
        {
            if (state == "Maharashtra")
            {
                obj.Add(new Author("Arihant","Rode"));
                obj.Add(new Author("Chirag","Bedi"));
                obj.Add(new Author("Ayushya","Tripathi"));
                obj.Add(new Author("Ashish","Tade"));
            }
            return obj;
        }
    }
}