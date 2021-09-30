﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Domain
{
   public abstract class Employee: BaseModel
   {
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string Address { get; set; }
      public bool IsDeleted { get; set; }
   }
}
