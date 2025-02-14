using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SRM_86.Models;
using SRM_86.Repo;
using Serilog;

namespace SRM_86.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquitiesController : ControllerBase
    {
        IEquities _equity;
        //private readonly ILogger _logger;

        public EquitiesController(IEquities equity)
        {
            _equity = equity;
            Log.Information("Logging Started for EquitiesController");
        }

        // Fetching All Equities
        [HttpGet("EquityInfo")]
        public async Task<ActionResult<IEnumerable<Equity>>> GetEquities()
        {
            Log.Information("Getting all Equities from the Database.");
            var info = await _equity.GetAllEquities();
            if (info == null)
            {
                Log.Warning("No data in equities");
                return NotFound();
            }
            Log.Information("Required Data successfully fetched.");
            return Ok(info);
        }

        // Fetching Equity by Id
        [HttpGet("EquityInfo/{id}")]
        public async Task<IActionResult> GetEquity([FromRoute] int id)
        {
            Log.Information("Getting equity details for id = " + id);
            var equity = await _equity.GetEquityById(id);

            if (equity == null)
            {
                Log.Warning("No equity for ID = " + id);
                return NotFound();
            }
            Log.Information("Required Data successfully fetched.");
            return Ok(equity);
        }

        // Fetching Equity by Name
        [HttpGet("EquityName")]
        public async Task<IActionResult> GetEquityByName([FromQuery] string name)
        {
            Log.Information("Getting equity details for name = " + name);
            var equity = await _equity.GetEquityByName(name);

            if (equity == null)
            {
                Log.Warning("No equity for name = " + name);
                return NotFound();
            }
            Log.Information("Required Data successfully fetched.");
            return Ok(equity);
        }

        // Adding a new Equity
        [HttpPost("Add")]
        public async Task<IActionResult> PostEquity([FromBody] Equity equity)
        {
            Log.Information("Adding equity to DB");
            await _equity.AddNewEquity(equity);

            Log.Information("Insertion successful");
            Log.Information("201-Created at action result returned");
            return CreatedAtAction("GetEquity", new { id = equity.SecurityId, controller = "Equities" }, equity);
            
        }


        // Updating Equity

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> PutEquity([FromRoute] int id, [FromBody] Equity equity)
        {
            Log.Information("Checking for match of id");
            
            if (id != equity.SecurityId)
            {
                Log.Error("Id not matched. Bad request. Updation failed");
                return BadRequest("ID not  matched");
            }
            Log.Information("Id matched. Updating record.");
            var str = await _equity.UpdateEquityById(id, equity);

            if (str != "Updated Successfully")
            {
                Log.Error("Updation failed");
                return BadRequest("Updation failed");
            }
            Log.Information("Updation successful");
            return Ok(str);
        }

        // Deleting an equity
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteEquity([FromRoute] int id)
        {
            Log.Information("Fetching record with required id");
            var str = await _equity.DeleteEquityById(id);
            
            if (str == null)
            {
                Log.Error("Id not found. Bad Request. Cannot delete non existing record");
                return NotFound();
            }
            Log.Information("ID found. Deleting record...");
            Log.Information("Deletion successful");
            return NoContent();
        }

        // Patching api
        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchEquity(int id, [FromBody] JsonPatchDocument patch)
        {
            var result = await _equity.UpdateSpecificEquity(id, patch);

            if (result == "Equity not found")
            {
                return NotFound(result);
            }

            return NoContent(); // Successfully updated the equity
        }


    }
}
