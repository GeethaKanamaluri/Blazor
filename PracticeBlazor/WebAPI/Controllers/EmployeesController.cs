using DataModels;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController :ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }
        [HttpGet]
        public async Task<ActionResult> GetEmployee()
        {
            try
            {
                return Ok(await _employeeRepository.GetEmployeees());
            }
            catch (Exception ex)
            {

                throw ex;
            }            
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Emplyeee>> GetEmployee(int id)
        {
            try
            {
                var result = await _employeeRepository.GetEmployee(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception EX)
            {

                throw EX;
            }
          
        }

        [HttpPost]
        public async Task<ActionResult<Emplyeee>> createEmployee(Emplyeee employeee)
        {

            try
            {
                if (employeee == null)
                {
                    return BadRequest();
                }
                else
                {
                    var result = await _employeeRepository.AddEmployee(employeee);

                    return Created(nameof(GetEmployee), new { id = result.EmployeeId });
                }
               
            }
            catch (Exception)
            {

                throw;
            }
           
        }

    }
}
