using Phonebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PhoneBook.Services
{
    public interface IContactServices
    {
        Task<List<Contact>> GetList();
    }

    public class ContactApiServices : IContactServices
    {
        public Task<List<Contact>> GetList()
        {
            throw new NotImplementedException();
        }
    }
}