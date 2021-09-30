using AutoCenter.Domain;
using AutoCenter.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository
{
   public class DriverRepository : BaseRepository<Driver>, IRepository<Driver>
   {
      public DriverRepository(AppContext context) : base(context)
      {

      }
   }
}
