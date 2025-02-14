using Microsoft.AspNetCore.Mvc;
using IVP_API.Models;

namespace IVP_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [BindProperties(SupportsGet = true)]
    public class CountryController: ControllerBase
    {
        //[HttpPost("Get")]
        //public IActionResult GetCountry([FromBody] Country country)
        //{
        //    return Ok($"{country.CID} - {country.Name} - {country.Area}");
        //}

        //[HttpPut("Put/{id}")]
        //public IActionResult PutCountry([FromBody] Country country, [FromRoute] int id)
        //{
        //    if (id == 100)
        //    {
        //        return Ok($"{country.CID} - {country.Name} - {country.Area}");
        //    }
        //    else
        //    {
        //        return BadRequest();
        //    }
        //}

        [HttpGet("Get")]
        public IActionResult GetDetails([FromHeader] string Name, [FromHeader] int Id)
        {
            return Ok(Name + " " +  Id);
        }

        [HttpPost("Post")]
        public IActionResult UPdateDetails([FromHeader] Country country)
        {
            return Ok($"{country.CID} - {country.Name} - {country.Area}");
        }

        //[HttpGet("Get/{CID}/{Name}/{Area}")]
        //public IActionResult GetCountry([FromRoute] Country country)
        //{
        //    return Ok($"{country.CID} - {country.Name} - {country.Area}");
        //}

        //[HttpPost("Add")]
        //public IActionResult AddCountry([FromQuery] Country country)
        //{
        //    return Ok($"{country.CID} - {country.Name} - {country.Area}");
        //}

        //[HttpPut("Edit")]
        //public IActionResult EditCountry([FromForm] Country country)
        //{
        //    return Ok($"{country.CID} - {country.Name} - {country.Area}");
        //}

        //[HttpPut("Put/{id:int}")]
        //public IActionResult PutDetails([FromForm] string name, [FromRoute] int id, [FromQuery] double area)
        //{
        //    return Ok($"{id} - {name} - {area}");
        //}

        //public int CID { get; set; }
        //public string Name { get; set; }
        //public double Area { get; set; }

        //[HttpPost]
        //[Route("Add")]
        //public IActionResult AddCountry()
        //{
        //    return Ok(this.Name + " " + this.CID + " " + this.Area);
        //}


        //[BindProperty(SupportsGet = true)]
        //public Country CDetails { get; set; }
        //[HttpGet]
        //[Route("Add")]
        //public IActionResult AddCountry()
        //{
        //    return Ok(this.CDetails.Name + " " + this.CDetails.CID + " " + this.CDetails.Area);
        //}

        //[BindProperty]
        //public Country CDetails { get; set; }
        //[HttpPost]
        //[Route("Add")]
        //public IActionResult AddCountry()
        //{
        //    return Ok(this.CDetails.Name + " " + this.CDetails.CID + " " + this.CDetails.Area);
        //}

        //[BindProperty]
        //public int CID { get; set; }

        //[BindProperty]
        //public string Name { get; set; }

        //[BindProperty]
        //public double Area { get; set; }

        //[HttpPost]
        //[Route("Add")]
        //public IActionResult AddCountry()
        //{
        //    return Ok(this.Name + " " + this.CID + " " + this.Area);
        //}
    }
}
