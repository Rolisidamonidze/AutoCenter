using AutoCenter.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository.Interfaces
{
   public interface IRepository<TModel> where TModel : class
   {
      AppDbContext DbContext { get; set; }
      DbSet<TModel> DbSet { get; }
      TModel Insert(TModel model);
      TModel Update(TModel model);
      TModel Delete(TModel model);
      IEnumerable<TModel> SelectAll();
      TModel Select(Func<TModel, bool> predicate);
   }
}
