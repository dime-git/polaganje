using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Book
    {
        public Book()
        {
            Clients = new List<Client>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Author { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Top Year of Publishing must be a number")]
        public string YearOfPublishing { get; set; }
        public string Photo { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}
