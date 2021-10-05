using AutoCenter.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Domain
{
   public class Order: IIdentity
   {
      public int ID { get; set; }
      public Customer Customer { get; set; }
      public DateTime OrderDate { get; set; }
   }
}
