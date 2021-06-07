using System;
using Microsoft.EntityFrameworkCore;
using CRUD_with_ASP.NET.Models;


namespace CRUD_with_ASP.NET.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<ShipmentModel> Shipments { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 1, Name="Phone", Description="New device", Price=532.2f});
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 2, Name="Laptop", Description="Used before", Price=122.2f});
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 3, Name="TV", Description="New type of TV", Price=532.2f});

        }


    }
}
