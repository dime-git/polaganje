using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class ClientsByBook
    {
        public Book Book { get; set; }
        public List<Client> Clients { get; set; }

        public ClientsByBook()
        {
            Clients = new List<Client>();
        }
    }
}