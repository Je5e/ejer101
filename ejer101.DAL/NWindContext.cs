using Microsoft.EntityFrameworkCore;
using System;
using ejer101.Entities;

namespace ejer101.DAL
{
    public class NWindContext:DbContext
    {
        
        public DbSet<Order>  Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=NWindDB;Integrated Security=True");
        }

    }
}
