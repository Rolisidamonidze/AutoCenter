using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Domain
{
   public class Driver : Employee
   {
      public string LicenseNumbers { get; set; }
      public string LicenseCategory { get; set; }
   }
}
