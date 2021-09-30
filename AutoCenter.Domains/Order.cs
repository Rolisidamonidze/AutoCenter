using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Domain
{
   public class Order: BaseModel
   {
      public Customer Customer { get; set; }
      public Driver Driver { get; set; }
      public decimal Price { get; set; }
      public DateTime OrderDate { get; set; }
      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set; }
      public ICollection<CarOrder> CarOrders { get; set; }
   }
}
