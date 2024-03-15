using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BusinessObjects;

namespace OrderService.Data
{
    public class OrderServiceContext : DbContext
    {
        public OrderServiceContext(DbContextOptions<OrderServiceContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(new Order
            {
                OrderID = 1,
                OrderDate = DateTime.Now,
              
            });


        }
    }
}