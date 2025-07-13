using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Lab5.Models;

namespace Lab5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,POC")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees = new()
        {
            new Employee { Id = 1, Name = "Alice", Salary = 60000, Department = "HR" },
            new Employee { Id = 2, Name = "Bob", Salary = 70000, Department = "IT" },
            new Employee { Id = 3, Name = "Charlie", Salary = 80000, Department = "Finance" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return Ok(_employees);
        }
    }
}
