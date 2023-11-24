using Microsoft.EntityFrameworkCore;
using Project.CORE.Entities.Concrete;
using Project.DAL.SqlMapping;
using Project.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Context
{
    public class MyContext: DbContext
    {




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=STORMDB;Trusted_Connection=true");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CampaignConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new OrderCampaignDetailConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCampaignDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new BasketConfiguration());
            modelBuilder.ApplyConfiguration(new Userconfiguration());
        }
          
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderCampaignDetail> OrderCampaignDetails { get; set; }
        public DbSet<ProductCampaignDetail> ProductCampaignDetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Basket> Cart { get; set; }
      

    }
}
