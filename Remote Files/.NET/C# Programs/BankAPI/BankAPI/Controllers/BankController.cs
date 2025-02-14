using BankAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        SecurityDbContext _context;
        public BankController(SecurityDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Get")]
        public IActionResult GetAllDetails ()
        {
            var data = _context.Banks.ToList();
            return Ok(data);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById (int id)
        {
            var data = _context.Banks.Find(id);
            return Ok(data);
        }

        [HttpPost("Post")]
        public IActionResult AddCustomer(Bank customer)
        {
            _context.Banks.Add(customer);
            return Ok("Data added successfully");
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            var data = _context.Banks.Find(id);
            _context.Banks.Remove(data);
            _context.SaveChanges();
            return Ok("Data deleted successfully");
        }

        [HttpPut("Edit/{id}")]
        public IActionResult UpdateCustomer(int id, Bank customer)
        {
            _context.Banks.Update(customer);
            _context.SaveChanges();
            return Ok("Update Successfully");
        }

        [HttpPatch("EditSpecific")]
        public IActionResult EditSpecificDetails()
    }
}
