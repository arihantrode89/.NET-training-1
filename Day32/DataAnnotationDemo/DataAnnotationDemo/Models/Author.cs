using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotationDemo.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        [MinLength(5,ErrorMessage ="Name should be greater than 5 letter")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Email { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}