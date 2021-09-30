using AutoCenter.Domain;
using AutoCenter.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository
{
   public class CarTypeRepository : BaseRepository<CarType>, IRepository<CarType>
   {
      public CarTypeRepository(AppContext context) : base(context)
      {

      }
   }
}
