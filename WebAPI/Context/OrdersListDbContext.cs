using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Context
{
    public class OrdersListDbContext: DbContext
    {
        public OrdersListDbContext() : base("DefaultConnection") { }

        public DbSet<Order> Orders { get; set; }

        
    }
}