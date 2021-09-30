using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoCenter.Domain
{
   public class Car: BaseModel
   {
      public string Brand { get; set; }
      public string Model { get; set; }
      public string Color { get; set; }
      public string PlateNumbers { get; set; }
      public decimal RentalPrice { get; set; }
      public bool IsDeleted { get; set; }
      public CarType Type { get; set; }
      public ICollection<CarOrder> CarOrders { get; set; }
   }
}
