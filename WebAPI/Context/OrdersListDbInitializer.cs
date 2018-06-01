using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Context
{

    public class OrdersListDbInitializer : DropCreateDatabaseIfModelChanges<OrdersListDbContext>
    {
        protected override void Seed(OrdersListDbContext context)
        {
            base.Seed(context);

            var orders = new Order { Title = "Test", Complete = true, CreationTime = DateTime.Now };

            context.Orders.Add(orders);
            context.SaveChanges();
        }
    }
}
