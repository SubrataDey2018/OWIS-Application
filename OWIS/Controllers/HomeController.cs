using Microsoft.AspNetCore.Mvc;
using OWIS.Business.Interface;
using OWIS.Models;
using System.Diagnostics;

namespace OWIS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeBusiness _employeeBusiness;
        public HomeController(ILogger<HomeController> logger, IEmployeeBusiness employeeBusiness)
        {
            _logger = logger;
            _employeeBusiness = employeeBusiness;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetEmployee(int id)
        {
            var employee = _employeeBusiness.GetEmployee(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Json(new
            {
                name = employee.EmployeeName,
                department = employee.DepartmentName,
                salary = employee.EmployeeSalary
            });
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
