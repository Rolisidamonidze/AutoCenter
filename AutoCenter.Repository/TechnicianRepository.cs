using AutoCenter.Domain;
using AutoCenter.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository
{
   public class TechnicianRepository : BaseRepository<Technician>, IRepository<Technician>
   {
      public TechnicianRepository(AppContext context) : base(context)
      {

      }
   }
}

