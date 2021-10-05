using AutoCenter.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Domain
{
   public class OrderDetails: IIdentity
   {
      public int ID { get; set; }
      public Order Order { get; set; }
      public Car Car { get; set; }
      public Driver Driver { get; set; }
      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set; }
      public decimal Price { get; set; }
   }
}
