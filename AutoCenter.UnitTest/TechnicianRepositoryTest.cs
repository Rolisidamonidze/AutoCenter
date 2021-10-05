using AutoCenter.Domain;
using AutoCenter.Repository;
using AutoCenter.Repository.Context;
using AutoCenter.Repository.Interfaces;
using AutoCenter.UnitTest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.UnitTest
{
   public class TechnicianRepositoryTest : BaseRepositoryTest<Technician, TechnicianRepository>
   {
      public TechnicianRepositoryTest()
      {
         ModelForInsert = new Technician
         {
            FirstName = "Shako",
            LastName = "Kalabegashvili",
            Address = "Ortachala 1",
            Experience = "He Has worked at BMW for 3 years",
            Qualification = "Engine expert"
         };
      }
   }
}
