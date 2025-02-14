using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace IVPLoggingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ILogger _logger;
        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
            _logger.LogInformation("Logging Started for TestController");
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Get method called");
            return Ok("Data sent successfully.");
        }

        [HttpGet("Divide")]
        public IActionResult Divide()
        {
            _logger.LogInformation($"Divide method called." + DateTime.Now.ToString());
            int x = 10;
            int y = 0;
            _logger.LogInformation($"Value of x = {x} and y = {y}");
                try
                {
                    return Ok(x / y);
                }
                catch(DivideByZeroException ex)
                {
                    _logger.LogError("Exception occured." + DateTime.Now.ToString());
                    _logger.LogCritical(ex.Message);
                }
                finally
                {
                    _logger.LogInformation("Method execution over." + DateTime.Now.ToString());
                }
            return BadRequest();
        }

    }
}
