using System;
using System.Linq;
using AutoCenter.Domain;
using AutoCenter.Repository;
using AutoCenter.Repository.Context;

namespace AutoCenter.App
{
   class Program
   {
      static void Main(string[] args)
      {
         using (var context = new AppDbContext())
         {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
         }
      }
   }
}
