using AutoCenter.Domain;
using AutoCenter.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository
{
   public class EmployeeRepository: BaseRepository<Employee>, IRepository<Employee>
   {
      public EmployeeRepository(AppContext context): base(context)
      {

      }
   }
}
