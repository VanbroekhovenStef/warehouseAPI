using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.DAL.Models;

namespace Warehouse.DAL.Data
{
    public class WarehouseContext : DbContext
    {
        public WarehouseContext(DbContextOptions<WarehouseContext> options) : base(options)
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Packaging> Packagings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPackaging> ProductPackagings { get; set; }
        public DbSet<Order> Orders { get; set; }        
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

/*        HasOne(e => e.Addresses).WithMany().OnDelete(DeleteBehavior.Restrict)
*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().ToTable("Countries");
            modelBuilder.Entity<Address>().ToTable("Addresses").HasOne(e => e.Country).WithMany().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Role>().ToTable("Roles");
            modelBuilder.Entity<Packaging>().ToTable("Packagings");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<ProductPackaging>().ToTable("ProductPackagings");
            modelBuilder.Entity<Order>().ToTable("Orders").HasOne(e => e.User).WithMany().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Stock>().ToTable("Stocks").HasOne(e => e.User).WithMany().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<OrderLine>().ToTable("OrderLines").HasOne(e => e.Stock).WithMany().OnDelete(DeleteBehavior.Restrict);
        }


    }
}
