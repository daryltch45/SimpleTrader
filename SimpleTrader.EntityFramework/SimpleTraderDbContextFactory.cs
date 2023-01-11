using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrader.EntityFramework
{
  //when you run migrations use this DbContext 
  public class SimpleTraderDbContextFactory : IDesignTimeDbContextFactory<SimpleTraderDbContext>
  {
    public SimpleTraderDbContext CreateDbContext(string[] args)
    {
      var options = new DbContextOptionsBuilder<SimpleTraderDbContext>();
      options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SimpleTraderDB;Trusted_Connection=True;");

      return new SimpleTraderDbContext(options.Options);
    }
  }
}
