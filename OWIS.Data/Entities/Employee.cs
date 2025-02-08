using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWIS.Data.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string DepartmentName { get; set; }
        //public int DepartmentId { get; set; }
        public decimal EmployeeSalary { get; set; }
        public Department Department { get; set; }
        public Salary Salary { get; set; }
    }
}
