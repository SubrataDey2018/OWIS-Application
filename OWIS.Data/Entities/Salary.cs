﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWIS.Data.Entities
{
    public class Salary
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public decimal EmployeeSalary { get; set; }
    }
}
