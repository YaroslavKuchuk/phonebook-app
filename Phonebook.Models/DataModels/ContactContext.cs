using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Phonebook.Models.DataModels
{
    public class ContactContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Phone> Phones { get; set; }

        public DbSet<Group> Groups { get; set; }
    }
}
