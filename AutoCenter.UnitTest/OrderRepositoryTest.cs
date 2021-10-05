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
   public class OrderRepositoryTest: BaseRepositoryTest<Order, OrderRepository>
   {
      public OrderRepositoryTest()
      {
         ModelForInsert = new Order
         {
            OrderDate = DateTime.Now,
            //StartDate = DateTime.Now.AddDays(1),
            //EndDate = new DateTime(2021, 11, 1),
            //Price = 110.50m,
            //Customer
            //Driver
         };
      }
   }
}
