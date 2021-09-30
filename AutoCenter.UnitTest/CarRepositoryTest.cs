using AutoCenter.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AutoCenter.UnitTest
{
   public class CarRepositoryTest : BaseRepositoryTest<Car>
   {
      public override void Insert()
      {
         var initialCount = _dbSet.Count();
         _dbSet.Add(new Car
         {
            Brand = "BMW",
            Type = new CarType
            {
               Name = "sedan"
            },
            Model = "F10",
            Color = "Black",
            PlateNumbers = "si-700-da",
            RentalPrice = 100
         });
         _context.SaveChanges();
         var finalCount = _dbSet.Count();
         Assert.Equal(initialCount + 1, finalCount);
      }
   }
}
