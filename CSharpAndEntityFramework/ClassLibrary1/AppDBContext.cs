﻿using EFLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFLibrary {
    public class AppDbContext : DbContext {
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            if (!builder.IsConfigured) {
                builder.UseLazyLoadingProxies();
                builder.UseSqlServer(@"server = localhost\sqlexpress; database = CustEfDb; trusted_connection = true;");
            }
        }
        protected override void OnModelCreating(ModelBuilder model) {
            model.Entity<Product>(e => {
                e.HasKey(x => x.Id);
                e.Property(x => x.Code).HasMaxLength(10).IsRequired();
                e.Property(x => x.Name).HasMaxLength(30).IsRequired();
                e.Property(x => x.Price);
                e.HasIndex(x => x.Code).IsUnique();
            });
            model.Entity<Customer>(e => {

            });
            model.Entity<Order>(e => {

            });
        }
    }
}
