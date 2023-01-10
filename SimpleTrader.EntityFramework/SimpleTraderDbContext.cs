using Microsoft.EntityFrameworkCore;
using SimpleTrader.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrader.EntityFramework
{
  public class SimpleTraderDbContext: DbContext
  {
    public SimpleTraderDbContext(DbContextOptions options) : base(options)
    {

    }

    //Which kind of entities we want to store in our Database?
    public DbSet<User> Users { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<AssetTransaction> AssetTransactions { get; set; }

    //we want the stock object to be embeded in the table AssetTransaction
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<AssetTransaction>().OwnsOne(a => a.Stock);// an Entity of type ModelBuilder owns a Stock 
      base.OnModelCreating(modelBuilder);
    }
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //  optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SimpleTraderDB;Trusted_Connection=True;") ;
    //  base.OnConfiguring(optionsBuilder);
    //}
  }
}
