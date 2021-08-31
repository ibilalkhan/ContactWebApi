using ContactWebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ContactWebApi.Entities
{
    public class ContactRepository : IContactService
    {
        private DataContext _context = new DataContext();
        public async Task<IEnumerable<Contact>> GetAll()
        {
            return _context.Contacts.ToList();
        }

        public async Task<Contact> GetContact(int Id)
        {
            return _context.Contacts.FirstOrDefault(a => a.Id == Id);
        }
    }
}
