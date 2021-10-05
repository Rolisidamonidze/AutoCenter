using AutoCenter.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoCenter.Domain
{
   public class Car: IIdentity
   {
      public int ID { get; set; }
      public string Brand { get; set; }
      public string Model { get; set; }
      public string Color { get; set; }
      public string PlateNumbers { get; set; }
      public decimal RentalPrice { get; set; }
      public bool IsDeleted { get; set; }
      public CarType CarType { get; set; }
   }
}
