﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAnnotationDemo.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Authors { get; set; }
    }
}