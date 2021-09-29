using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class BookDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Book> Books { get; set; }
        public BookDbContext() : base("BookApp")
        {

        }
        public static BookDbContext Create()
        {
            return new BookDbContext();
        }
    }
}