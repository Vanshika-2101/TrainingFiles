using System.Net.Sockets;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IVP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet] //Swagger needs annotations for testing however postman would've worked.
        [Route("GV")] 
        public string GetValues()
        {
            return "Returning Cutsomer Values";
        }

        [HttpGet]
        [Route("GI")]
        public string GetInfo()
        {
            return "Returning Basic Information";
        }
    }
}
