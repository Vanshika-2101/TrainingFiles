using Microsoft.AspNetCore.Mvc;

namespace IVP_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("SB")]
        public  string SBAccount()  //action
        {
            return "Saving Bank account details";
        }

        [Route("CU")]
        [HttpGet]
        public string CUAccount()   //action
        {
            return "Current Bank account details";
        }
    }
}
