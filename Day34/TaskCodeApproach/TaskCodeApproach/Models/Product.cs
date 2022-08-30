using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TaskCodeApproach.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage ="Product Name is Required")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Product Price is Required")]
        public float Price { get; set; }
        [ForeignKey("Categories")]
        public int CategoryId { get; set; }

        public virtual Category Categories { get; set; }
    }
}