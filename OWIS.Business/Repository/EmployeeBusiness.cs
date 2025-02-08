using OWIS.Business.BusinessData;
using OWIS.Business.Interface;
using OWIS.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWIS.Business.Repository
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeBusiness(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public EmployeeData GetEmployee(int id)
        {
            var employee = _employeeRepository.GetEmployee(id);
            return new EmployeeData
            {
                EmployeeId = id,
                EmployeeName = employee.EmployeeName,
                DepartmentName = employee.DepartmentName,
                EmployeeSalary = employee.EmployeeSalary
            };
        }
    }
}
