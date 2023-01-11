using Microsoft.EntityFrameworkCore;
using SimpleTrader.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrader.EntityFramework
{
  public class SimpleTraderDbContext: DbContext
  {
    //Which kind of entities we want to store in our Database?
    public DbSet<User> Users { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<AssetTransaction> AssetTransactions { get; set; }

    //Problem: Error by creating the Dataset because Stock does have an id 
    //Solution: Embed the stock object in the table AssetTransaction
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<AssetTransaction>().OwnsOne(a => a.Stock);// an Entity of type ModelBuilder owns a Stock 
      base.OnModelCreating(modelBuilder);
    }
    //Replaced by SimpleTraderDbContextFactory
    //Reason: Make the connection string more dynamic 
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //  optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SimpleTraderDB;Trusted_Connection=True;") ;
    //  base.OnConfiguring(optionsBuilder);
    //}
    // This constructor got added for the instance 
    public SimpleTraderDbContext(DbContextOptions options) : base(options) { }

  }
}
