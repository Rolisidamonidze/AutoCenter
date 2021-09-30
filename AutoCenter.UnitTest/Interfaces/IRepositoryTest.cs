using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.UnitTest.Interfaces
{
   interface IRepositoryTest<TModel>
   {
      void Insert();
      void Update();
      void Delete();
      void Select();
   }
}
