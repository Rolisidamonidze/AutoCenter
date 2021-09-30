using AutoCenter.Domain.Interfaces;
using AutoCenter.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository
{
   public class BaseRepository<T>: IRepository<T> where T: class, IEntity
   {
      AppContext _context;
      private DbSet<T> _dbSet;

      public BaseRepository(AppContext appContext)
      {
         _context = appContext;
         _dbSet = _context.Set<T>();
      }

      public virtual T Insert(T model)
      {
         _dbSet.Add(model);
         return model;
      }

      public virtual T Update(T model)
      {
         _dbSet.Update(model);
         return model;
      }

      public virtual T Delete(T model)
      {
         _dbSet.Remove(model);
         return model;
      }

      public virtual IEnumerable<T> SelectAll()
      {
         return _dbSet.AsEnumerable();
      }

      public virtual T Where(Func<T, bool> predicate)
      {
         return _dbSet.FirstOrDefault(predicate);
      }

      public virtual IDbContextTransaction BeginTransaction()
      {
         return _context.Database.BeginTransaction();
      }

      public virtual void CommitTransaction()
      {
         _context.Database.CommitTransaction();
      }

      public virtual void RollbackTransaction()
      {
         _context.Database.RollbackTransaction();
      }
   }
}
