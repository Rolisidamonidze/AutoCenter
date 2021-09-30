﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Domain
{
   public class Customer: BaseModel
   {
      public string Firstname { get; set; }
      public string Lastname { get; set; }
      public string Address { get; set; }
      public string Phone { get; set; }
   }
}
