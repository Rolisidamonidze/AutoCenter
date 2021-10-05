using AutoCenter.Domain;
using AutoCenter.Repository;
using AutoCenter.Repository.Context;
using AutoCenter.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AutoCenter.UnitTest.Data;

namespace AutoCenter.UnitTest
{
   public class CarRepositoryTest : BaseRepositoryTest<Car, CarRepository>
   {
      public CarRepositoryTest()
      {
         ModelForInsert = new Car
         {
            Brand = "BMW",
            Model = "F10",
            Color = "Black",
            PlateNumbers = "si-700-da",
            RentalPrice = 100
         };
      }
   }
}
