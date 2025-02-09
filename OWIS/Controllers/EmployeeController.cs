using Microsoft.AspNetCore.Mvc;
using OWIS.Business.Interface;

namespace OWIS.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeBusiness _employeeBusiness;
        public EmployeeController(IEmployeeBusiness employeeBusiness)
        {
            _employeeBusiness = employeeBusiness;
        }

        [HttpGet]
        public IActionResult GetEmployee(int id)
        {
            var employee = _employeeBusiness.GetEmployee(id);
            if (employee == null)
            {
                return NotFound();
            }

            return Json(employee);
        }
    }
}
