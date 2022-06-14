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
        public DbSet<Packaging> Packagings { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

/*        HasOne(e => e.Addresses).WithMany().OnDelete(DeleteBehavior.Restrict)
*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().ToTable("Countries");
            modelBuilder.Entity<Address>().ToTable("Addresses");
            modelBuilder.Entity<Packaging>().ToTable("Packagings");
            modelBuilder.Entity<Item>().ToTable("Items");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Order>().ToTable("Orders");
            modelBuilder.Entity<OrderLine>().ToTable("OrderLines");
        }


    }
}
