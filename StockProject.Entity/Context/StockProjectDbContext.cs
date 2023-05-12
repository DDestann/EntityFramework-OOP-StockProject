using StockProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProject.Entity.Context
{
    public class StockProjectDbContext : DbContext
    {

        public StockProjectDbContext()
        {
            Database.Connection.ConnectionString = @"Server=DESKTOP-R9KRKE3;Database=DbStockProject;Trusted_Connection=True;";
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
