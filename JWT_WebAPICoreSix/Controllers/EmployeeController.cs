using JWT_WebAPICoreSix.Interfaces;
using JWT_WebAPICoreSix.Models;
using JWT_WebAPICoreSix.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JWT_WebAPICoreSix.Controllers
{
    /// <summary>
    /// StackOverflow example
    /// </summary>
    /// <response code="200">All good here</response>
    /// <response code="401">Unauthorized</response>
    [ApiController]
    [Route("api/[controller]")]
   
    public class  EmployeeController : ControllerBase
    {

        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeServic)
        {
            _employeeService = employeeServic;
        }
        // GET: api/<Employeetroller>
       
        public List<Employee> Get()
        {
            var employee = _employeeService.GetEmployeesDetails();
            return employee;
        }

        // GET api/<Employeetroller>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            var emp = _employeeService.GetEmployeesDetails(id);
            return emp;
        }

        // POST api/<Employeetroller>
        [HttpPost]
        public Employee Post([FromBody] Employee value)
        {
            var emp= _employeeService.AddEmployee(value);
            return emp;
        }

        // PUT api/<Employeetroller>/5
        [HttpPut("{id}")]
        public Employee Put(int id, [FromBody] Employee value)
        {
            var emp = _employeeService.UpdateEmployee(value);
            return emp; 
        }

        // DELETE api/<Employeetroller>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var isDeleted= _employeeService.DeleteEmployee(id);
            return isDeleted;
        }
    }
}
