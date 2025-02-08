using OWIS.Data.Entities;
using OWIS.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWIS.Data.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Where(e => e.Id == id).FirstOrDefault();
        }
    }
}
