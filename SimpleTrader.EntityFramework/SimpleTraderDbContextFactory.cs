using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrader.EntityFramework
{
  //This class gives the DbContext used to run the migration 
  public class SimpleTraderDbContextFactory : IDesignTimeDbContextFactory<SimpleTraderDbContext>
  {
    public SimpleTraderDbContext CreateDbContext(string[] args = null)
    {
      var options = new DbContextOptionsBuilder<SimpleTraderDbContext>();
      options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SimpleTraderDB;Trusted_Connection=True;");

      return new SimpleTraderDbContext(options.Options);
    }
  }
}
