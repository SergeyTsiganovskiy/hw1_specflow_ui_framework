﻿using System;
using System.Collections.Generic;
using System.Text;

namespace solid_violations.DependencyInversion
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }
}