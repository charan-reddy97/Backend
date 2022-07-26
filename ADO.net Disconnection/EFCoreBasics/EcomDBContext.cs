using EFCoreBasics.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBasics
{
    public class EcomDBContext:DbContext
    {
        public static ILoggerFactory log = LoggerFactory.Create(builder => builder.AddDebug());
         public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(log);
            optionsBuilder.UseSqlServer("Integrated Security=False;Server=.\\SqlExpress;uid=sa;password=pass@123;database=ECOM_TRAINING");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasQueryFilter(d => d.DeletedDate == null);
        }
    }
}
