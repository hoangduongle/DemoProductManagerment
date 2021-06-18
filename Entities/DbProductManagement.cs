using DemoProductManagerment.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProductManagerment.Entities
{
    public class DbProductManagement : DbContext
    {
        public DbProductManagement(DbContextOptions<DbProductManagement> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                    new Category() { cateId = 1, cateName = "Asus" },
                    new Category() { cateId = 2, cateName = "Apple" }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product() { proId = 1, proName = "AsusROG", price = 10, amount = 100, cateId = 1 },
                    new Product() { proId = 2, proName = "Macbook", price = 10, amount = 100, cateId = 2 }
                );
        }

    }
}
