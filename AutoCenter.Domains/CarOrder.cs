using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Domain
{
   public class CarOrder: BaseModel
   {
      public Car Car { get; set; }
      public int CarID { get; set; }
      public Order Order { get; set; }
      public int OrderID { get; set; }
   }
}
