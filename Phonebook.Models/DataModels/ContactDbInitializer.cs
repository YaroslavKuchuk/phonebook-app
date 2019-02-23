using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Models.DataModels
{
    public class ContactDbInitializer : DropCreateDatabaseAlways<ContactContext>
    {

        protected override void Seed(ContactContext db)
        {
            db.Contacts.Add(new Contact { FirstName = "Alex", LastName = "Medved", Position = "student" });
            db.Contacts.Add(new Contact { FirstName = "John", LastName = "Smith", Position = "cook" });
            db.Contacts.Add(new Contact { FirstName = "Jack", LastName = "Williams", Position = "Senior developer" });

            db.Groups.Add(new Group { Name = "Колеги" });

            base.Seed(db);
        }
    }
}
