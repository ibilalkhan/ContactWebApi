using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactWebApi.Entities
{
  public class DataContext : DbContext
  {
    public DataContext() : base("ContactDbEntities")
    {
    }

    public DbSet<Contact> Contacts { get; set; }

  }    
 
}
