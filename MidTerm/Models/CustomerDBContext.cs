using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MidTerm.Models
{
    public class CustomerDBContext: DbContext
    {
        public CustomerDBContext(): base("conn") { }
        public DbSet<Customer> Customers { get; set;}
    }
}