using Microsoft.EntityFrameworkCore;
using SmartStock.Models;
using System.Collections.Generic;

namespace SmartStock.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Smartphone", Category = "Electronics", Price = 25000, Quantity = 15 },
                new Product { Id = 2, Name = "T-Shirt", Category = "Clothing", Price = 600, Quantity = 100 },
                new Product { Id = 3, Name = "Rice 5kg", Category = "Food", Price = 500, Quantity = 50 },
                new Product { Id = 4, Name = "Headphones", Category = "Electronics", Price = 1200, Quantity = 40 },
                new Product { Id = 5, Name = "Jeans", Category = "Clothing", Price = 1200, Quantity = 60 }
            );
        }
    }
}
