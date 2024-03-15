using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BusinessObjects;
using Microsoft.Extensions.Hosting;
using static NuGet.Packaging.PackagingConstants;

namespace ProductService.Data
{
    public class ProductServiceContext : DbContext
    {
        public ProductServiceContext(DbContextOptions<ProductServiceContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>().HasData(new Product
        //    {
        //        ProductID = 1,
        //        ProductName = "PC",
        //        Price = 450000,
        //        Description = "pc portable"
                
        //    });

         
        //}


    }
}
