using AutoCenter.Domain;
using AutoCenter.Repository;
using AutoCenter.Repository.Context;
using AutoCenter.UnitTest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.UnitTest
{
   public class DriverRepositoryTest: BaseRepositoryTest<Driver, DriverRepository>
   {
      public DriverRepositoryTest()
      {
         ModelForInsert = new Driver
         {
            FirstName = "Misho",
            LastName = "Magaldadze",
            Address = "Ortachala 2",
            LicenseCategory = "B,C",
            LicenseNumbers = "345643234565"
         };
      }
   }
}
