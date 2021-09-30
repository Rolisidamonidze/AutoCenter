using AutoCenter.Domain;
using AutoCenter.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository
{
   public class CarOrderRepository : BaseRepository<CarOrder>, IRepository<CarOrder>
   {
      public CarOrderRepository(AppContext context) : base(context)
      {

      }
   }
}

