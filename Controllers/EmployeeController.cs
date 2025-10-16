using EmployeeManagementAPI.Entity;
using EmployeeManagementAPI.Entity.Model;
using EmployeeManagementAPI.Entity.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace EmployeeManagementAPI.Controllers
{

    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly ManagementContext _dbContext;

        public EmployeeController(ILogger<EmployeeController> logger, ManagementContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }


        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _dbContext.employees;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var deleteEmployee = _dbContext.employees.Where(_ => _.EmployeeId == id).First();
                _dbContext.employees.Remove(deleteEmployee);
                await _dbContext.SaveChangesAsync();
            }
            catch
            {
                _logger.LogInformation($"Employee with id {id} is not exist");
            }

            return NoContent();
        }


        [HttpPut]
        public async Task<IActionResult> Update([FromBody] EmployeeRequest request)
        {
            Employee employee = new Employee
            {
                EmployeeId = request.employeeId,
                Name = request.name,
                Email = request.email,
                DepartmentId = request.departmentId,
                HireDate = request.hireDate,
                Position = request.position
            };

            _dbContext.employees.Update(employee);
            await _dbContext.SaveChangesAsync();
            return NoContent(); 
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] EmployeeRequest request)
        {
            Employee employee = new Employee
            {
                Name = request.name,
                Email = request.email,
                DepartmentId = request.departmentId,
                HireDate = request.hireDate,
                Position = request.position
            };

            _dbContext.employees.Add(employee);
            await _dbContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
