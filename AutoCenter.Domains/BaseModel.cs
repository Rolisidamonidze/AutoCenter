using AutoCenter.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Domain
{
   public class BaseModel: IEntity
   {
      public int ID { get; set; }
   }
}
