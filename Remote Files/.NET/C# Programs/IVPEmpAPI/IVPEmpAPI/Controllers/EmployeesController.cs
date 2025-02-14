using IVPEmpAPI.EmployeeRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmpModels.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace IVPEmpAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        IEmployee _emp;
        public EmployeesController(IEmployee emp)
        {
            _emp = emp;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> GetEmployees()
        {
            var info = await _emp.GetAllEmployees();
            if(info == null)
            {
                return BadRequest();
            }
            return Ok(info);
        }

        [HttpGet]
        [Route("Fetch/{id:int:range(10,1000)}")]
        public async Task<IActionResult> GetEmpById([FromRoute] int id)
        {
            var info = await _emp.GetEmployeeById(id);
            if(info == null)
            {
                return NotFound();
            }
            return Ok(info);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> AddEmp([FromBody] Employee employee)
        {
            int id = await _emp.AddEmployee(employee);
            //return Ok(str);
            return CreatedAtAction(nameof(GetEmpById), new { id = id, Controller = "Employees" }, id);
        }

        [HttpDelete("Delete/{Id:int:max(1000):min(10)}")]
        public async Task<IActionResult> DeleteEmp([FromRoute] int Id)
        {
            string str = await _emp.DeleteEmployee(Id);
            return Ok(str);
        }

        [HttpPut]
        [Route("Edit")]
        public async Task<IActionResult> EditEmp([FromBody] Employee employee, [FromQuery] int id)
        {
            string str = await _emp.UpdateEmployee(employee, id);
            return Ok(str);
        }

        [HttpPatch("EditSalary/{id}")]
        public async Task<IActionResult> EditSal([FromRoute] int id, [FromBody] JsonPatchDocument patch)
        {
            string str = await _emp.UpdateEmployeeSalary(id, patch);
            return Ok(str);
        }

        [HttpPatch("EditDesig/{id}")]
        public async Task<IActionResult> EditDesig([FromRoute] int id, [FromBody] JsonPatchDocument patch)
        {
            string str = await _emp.UpdateDesignation(id, patch);
            return Ok(str);
        }
    }
}
