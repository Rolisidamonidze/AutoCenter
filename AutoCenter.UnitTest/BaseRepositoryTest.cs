using AutoCenter.Domain.Interfaces;
using AutoCenter.Repository;
using AutoCenter.Repository.Context;
using AutoCenter.Repository.Interfaces;
using AutoCenter.UnitTest.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using AutoCenter.UnitTest.Data;

namespace AutoCenter.UnitTest
{
   [Collection("Sequential")]
   public abstract class BaseRepositoryTest<TModel, TRepo>
   where TModel : class, IIdentity, new()
   where TRepo : IRepository<TModel>, new()
   {
      public BaseRepositoryTest()
      {
         Repository = new();
      }

      protected TRepo Repository { get; set; }
      protected TModel ModelForInsert { get; set; }

      [Fact]
      public virtual void Insert()
      { 
         Repository.Insert(ModelForInsert);
         Repository.DbContext.SaveChanges();
         Assert.NotNull(ModelForInsert.ID);
      }
   }
}
