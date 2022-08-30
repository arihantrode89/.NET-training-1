﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskCodeApproach.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="Category Name is Required")]
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}