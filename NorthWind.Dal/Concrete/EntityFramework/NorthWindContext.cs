using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Text; 
using System.Threading.Tasks;
using NorthWind.Entities.Concrete;

namespace NorthWind.Dal.Concrete.EntityFramework
{
    public class NorthWindContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }


    }
}
