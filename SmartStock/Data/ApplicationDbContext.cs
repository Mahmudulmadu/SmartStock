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


            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Smartphone", Category = "Electronics", Price = 250.00m, Quantity = 15 },
                new Product { Id = 2, Name = "T-Shirt", Category = "Clothing", Price = 10.00m, Quantity = 100 },
                new Product { Id = 3, Name = "Rice 5kg", Category = "Food", Price = 5.50m, Quantity = 50 },
                new Product { Id = 4, Name = "Headphones", Category = "Electronics", Price = 29.99m, Quantity = 40 },
                new Product { Id = 5, Name = "Jeans", Category = "Clothing", Price = 19.99m, Quantity = 60 }
            );
        }
    }
}
