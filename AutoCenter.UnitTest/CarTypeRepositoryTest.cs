using AutoCenter.Domain;
using AutoCenter.Repository;
using AutoCenter.UnitTest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.UnitTest
{
   public class CarTypeRepositoryTest : BaseRepositoryTest<CarType, CarTypeRepository>
   {
      public CarTypeRepositoryTest() : base()
      {
         ModelForInsert = new CarType
         {
            Name = "Sedan"
         };
      }
   }
}
