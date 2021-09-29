using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Client
    {

        public Client()
        {
            Books = new List<Book>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int LibraryID { get; set; }
        [Range(5, 150, ErrorMessage = "Age must be a number between 5 and 150.")]
        public int Age { get; set; }
        public virtual ICollection<Book> Books { get; set; }

    }
}