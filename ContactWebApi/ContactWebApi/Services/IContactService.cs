using ContactWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ContactWebApi.Services
{
  public interface IContactService 
  {
        Task<Contact> GetContact(int Id);
        Task<IEnumerable<Contact>> GetAll();
    }
}
