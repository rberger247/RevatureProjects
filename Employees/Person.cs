﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
  abstract class Person
    {
        public string Name { get; set; }
        public string SSN { get; set; }

        public abstract void Routine();




    }
}
