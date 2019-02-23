using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PhoneBook.Models
{
    public class ContactContext:DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Phone> Phones { get; set; }

        public DbSet<Groups> Groups { get; set; }
    }
}