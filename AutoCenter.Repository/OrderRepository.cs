using AutoCenter.Domain;
using AutoCenter.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository
{
   public class OrderRepository : BaseRepository<Order>, IRepository<Order>
   {
      public OrderRepository(AppContext context) : base(context)
      {

      }
   }
}
