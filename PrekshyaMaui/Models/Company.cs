﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrekshyaMaui.Models
{
    public class Company
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; }
    }
}
