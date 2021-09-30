using AutoCenter.Domain.Interfaces;
using AutoCenter.Repository;
using AutoCenter.Repository.Interfaces;
using AutoCenter.UnitTest.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AutoCenter.UnitTest
{
   public abstract class BaseRepositoryTest<TModel> where TModel: class, IEntity, new()
   {
      protected Repository.AppContext _context;
      protected DbSet<TModel> _dbSet;

      public BaseRepositoryTest()
      {
         _context = new Repository.AppContext();
         _context.Database.EnsureCreated();
         _dbSet = _context.Set<TModel>();
      }

      [Fact]
      public virtual void Insert()
      {
         var initialCount = _dbSet.Count();
         _dbSet.Add(new TModel());
         _context.SaveChanges();
         var finalCount = _dbSet.Count();
         Assert.Equal(initialCount + 1, finalCount);
      }

      //[Fact]
      //public void Update()
      //{
      //   throw new NotImplementedException();
      //}

      //[Fact]
      //public void Delete()
      //{
      //   throw new NotImplementedException();
      //}

      //[Fact]
      //public void Select()
      //{
      //   throw new NotImplementedException();
      //}
   }
}
