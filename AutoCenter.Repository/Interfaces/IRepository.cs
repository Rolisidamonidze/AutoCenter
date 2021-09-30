using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository.Interfaces
{
   public interface IRepository<T>
   {
     T Insert(T model);
     T Update(T model);
     T Delete(T model);
   }
}
