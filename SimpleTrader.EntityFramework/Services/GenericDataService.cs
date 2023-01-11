using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SimpleTrader.Model;
using SimpleTrader.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.EntityFramework.Services
{
  /// <summary>
  /// Define all the crud operations for all our domain objects (Accounts, Users, AssetTransactions)
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public class GenericDataService<T> : IDataService<T> where T : DomainObject
  {
    //SimpleTraderDbContextFactory is used insead of the SimpleTraderDbContext(_contextFactory.Accounts, _contextFactory.Users.. )
    //Problem: if multiple Threads try to access to this DbContext at the same time, we might get errors(not Thread safe)
    //Solution: It's better to create a DbContext in each of these methods below
    private readonly SimpleTraderDbContextFactory _contextFactory;

    public GenericDataService(SimpleTraderDbContextFactory contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task<T> Create(T entity)
    {
      using (SimpleTraderDbContext context = _contextFactory.CreateDbContext())
      {
        //Set<T> returns the actual Dataset 
        //Then the new entity gets added 
        EntityEntry<T> createdEntity = await context.Set<T>().AddAsync(entity);
        await context.SaveChangesAsync();

        return createdEntity.Entity;
      }
    }

    public async Task<bool> Delete(int id)
    {
      using (SimpleTraderDbContext context = _contextFactory.CreateDbContext())
      {
        
        T entity = await context.Set<T>().FirstOrDefaultAsync(e => e.id == id );
        context.Set<T>().Remove(entity);
        await context.SaveChangesAsync();

        return true;
      }
    }

    public async Task<T> Get(int id)
    {
      using (SimpleTraderDbContext context = _contextFactory.CreateDbContext())
      {

        T entity = await context.Set<T>().FirstOrDefaultAsync(e => e.id == id);

        return entity;
      }
    }

    public async Task<IEnumerable<T>> GetAll()
    {
      using (SimpleTraderDbContext context = _contextFactory.CreateDbContext())
      {

        IEnumerable<T> entities = await context.Set<T>().ToListAsync();
        return entities;
      }
    }

    public async Task<T> Update(int id, T entity)
    {
      using (SimpleTraderDbContext context = _contextFactory.CreateDbContext())
      {
        entity.id = id;
        await context.SaveChangesAsync();

        return entity;
      }
    }
  }
}
