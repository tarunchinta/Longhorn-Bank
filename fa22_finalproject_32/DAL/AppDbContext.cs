using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using fa22_finalproject_32.Models;

namespace fa22_finalproject_32.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        //NOTE: This class definition references the user class for this project.  

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //this code makes sure the database is re-created on the $5/month Azure tier
            builder.HasPerformanceLevel("Basic");
            builder.HasServiceTier("Basic");

            // Add the shadow property to the model
            builder.Entity<StockPortfolio>()
                .Property<String>("AppUserForeignKey");


            //this code configures the 1:1 relationship between AppUser and StockPortfolio
            builder.Entity<AppUser>()
                .HasOne(sp => sp.StockPortfolio)
                .WithOne(u => u.AppUser)
                .HasForeignKey<StockPortfolio>("AppUserForeignKey");

            base.OnModelCreating(builder);
        }

        //TODO: Add Dbsets here.
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockPortfolio> StockPortfolios { get; set; }
        public DbSet<StockTransaction> StockTransaction { get; set; }
        public DbSet<StockType> StockType { get; set; }



        public DbSet<Account> Accounts { get; set; }
        public DbSet<Dispute> Disputes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

    }
}
