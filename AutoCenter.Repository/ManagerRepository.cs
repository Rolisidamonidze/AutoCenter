using AutoCenter.Domain;
using AutoCenter.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository
{
   public class ManagerRepository : BaseRepository<Manager>, IRepository<Manager>
   {
      public ManagerRepository(AppContext context) : base(context)
      {

      }
   }
}
