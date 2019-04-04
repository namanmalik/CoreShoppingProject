﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEcommerceUserPanal.Models
{
    public class ShopDataDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<ProductCategory> Categories { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        public ShopDataDbContext(DbContextOptions<ShopDataDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer("Data Source=TRD-517; Initial Catalog=ShoppingDemo;Integrated Security=true;");
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>(build =>
            {
                build.HasKey(t => new { t.OrderId, t.ProductId });
            }

            );
        }
    }
}
