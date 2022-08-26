using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataAnnotationDemo.Models
{
    public class AuthorContext:DbContext
    {
        public AuthorContext() : base("AuthorContext")
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}