using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace HandsOnMVCUsingEntityFrameworkCodeFirst.Entities
{
    public class OnlineECommContext:DbContext
    {
        public OnlineECommContext():base("OnlineECommDBConnection")
        {
            
        }
        //define entity sets
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}