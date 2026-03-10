using ASP.NETCoreD11.Context;
using ASP.NETCoreD11.Models;
using Azure.Messaging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_D11_API_lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        #region Context
        private readonly AppDbContext _context;
        public EmployeesController(AppDbContext context)
        {
            _context = context;
        }
        #endregion

        #region GETAll
        [HttpGet]
        public ActionResult<List<Employee>> GetAll()
        {
            var employees = _context.Employees.ToList();
            return Ok(employees); // return 200 + data
        }

        #endregion

        #region GETById
        [HttpGet("{id:int}")]
        public ActionResult<Employee> GetById(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return NotFound(new { Message = $"Employee with Id: {id} Not Found" }); // return 404
            return Ok(employee); // return 200 + data
        }
        #endregion

        #region GetByName
        [HttpGet("{name:alpha}")]
        public ActionResult<List<Employee>> GetByName(string name)
        {
            var employees = _context.Employees.Where(e => e.Name.Contains(name)).ToList();
            if (employees.Count == 0)
                return NotFound(new { Message = $"No Employees with Name Contains: {name} Not Found" }); // return 404
            return Ok(employees); // return 200 + data
        }
        #endregion

        #region Create

        [HttpPost]
        [Route("Createv01")]
        public ActionResult<Employee> CreateV01(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(); // return 400
            }
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return Ok(employee); // return 200 + data
        }

        [HttpPost]
        [Route("Createv02")]
        public ActionResult<Employee> CreateV02(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(); // return 400
            }
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return Created(); // return 201 that indicates that a new resource has been created successfully
        }

        [HttpPost]
        [Route("Createv03")]
        public ActionResult<Employee> CreateV03(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(); // return 400
            }
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return Created($"/api/employees/{employee.Id}", employee); // return 201 that indicates that a new resource has been created successfully
        }

        [HttpPost]
        [Route("Createv04")]
        public ActionResult<Employee> CreateV04(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(); // return 400
            }
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return CreatedAtAction("GetById", new { id = employee.Id }, employee); // return 201 that indicates that a new resource has been created successfully
        }
        #endregion

        #region Update
        [HttpPut("{id:int}")]

        public ActionResult update( [FromRoute] int id , [FromBody] Employee employee)
        {
          

            if (!ModelState.IsValid | id != employee.Id | employee is null)
            {
                return BadRequest(); // return 400 that indicates that the request is invalid
            }

            //catch to update employee
            var emp = _context.Employees.FirstOrDefault(e => e.Id == id);

            if (emp is null)
            {
                return NotFound(new { Message = $"Employee with Id: {id} Not Found" }); // return 404 that indicates that the resource was not found
            }

            emp.Name = employee.Name;
            emp.Age = employee.Age;
            emp.Salary = employee.Salary;

            _context.SaveChanges();

            return Ok(); 

        }


        #endregion

        #region Delete
        [HttpDelete("{id:int}")] // attribute routing with constraint to ensure that the id parameter is an integer 
        public ActionResult delete(int id)
        {
            var emp = _context.Employees.FirstOrDefault(e => e.Id == id);
            if (emp is null)
            {
                return NotFound(new { Message = $"Employee with Id: {id} Not Found" }); // return 404 that indicates that the resource was not found
            }
            _context.Employees.Remove(emp);
            _context.SaveChanges();
            //return Ok(); // return 200 that indicates that the request has succeeded
            return NoContent(); // return 204 that indicates that the request has succeeded but there is no content to return
        }
        #endregion

    }
}

