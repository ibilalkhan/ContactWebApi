using ContactWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ContactWebApi.Controllers
{
  public class ContactController : ApiController
  {
        private readonly ContactRepository _contactRepository = new ContactRepository();
        
        /// <summary>  
        /// Get contact By ID  
        /// </summary>  
        /// <param name="id"> id</param>  
        /// <returns>Contact by id </returns>  
        [HttpGet]
        [AllowAnonymous]
        public async Task<Contact> GetById(int id)
        {
            return await _contactRepository.GetContact(id);
        } 

        /// <summary>  
        /// Get all contacts  
        /// </summary>  
        /// <returns>List of contacts</returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IEnumerable<Contact>> GetAll()
        {
            return await _contactRepository.GetAll();
        }
    }
}
