using AutoCenter.Domain.Interfaces;
using AutoCenter.Repository.Context;
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
   
   public abstract class BaseRepository<TModel> : IRepository<TModel> where TModel : class, IIdentity
   {
      public BaseRepository()
      {
         DbContext = new AppDbContext();
      }

      public AppDbContext DbContext { get; set; }
      public DbSet<TModel> DbSet => DbContext.Set<TModel>();

      public virtual TModel Insert(TModel model)
      {
         DbSet.Add(model);
         return model;
      }

      public virtual TModel Update(TModel model)
      {
         DbSet.Update(model);
         return model;
      }

      public virtual TModel Delete(TModel model)
      {
         DbSet.Remove(model);
         return model;
      }

      public virtual IEnumerable<TModel> SelectAll()
      {
         return DbSet.AsEnumerable();
      }

      public virtual TModel Select(Func<TModel, bool> predicate)
      {
         return DbSet.FirstOrDefault(predicate);
      }

      public virtual IDbContextTransaction BeginTransaction()
      {
         return DbContext.Database.BeginTransaction();
      }

      public virtual void CommitTransaction()
      {
         DbContext.Database.CommitTransaction();
      }

      public virtual void RollbackTransaction()
      {
         DbContext.Database.RollbackTransaction();
      }
   }
}
