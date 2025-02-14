using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SRM_86.Models;
using SRM_86.Repo;

namespace SRM_86.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BondsController : ControllerBase
    {
        IBonds _bonds;


        public BondsController(IBonds bonds)
        {
            _bonds = bonds;
        }

        // Fetching All Bonds
        [HttpGet("BondInfo")]
        public async Task<IActionResult> GetBonds()
        {
            var info = await _bonds.GetAllBonds();
            if (info == null)
            {
                return NotFound();
            }
            return Ok(info);
        }

        // Fetching Bond by Id
        [HttpGet("BondInfo/{id}")]
        public async Task<IActionResult> GetBond([FromRoute] int id)
        {
            var bond = await _bonds.GetBondById(id);

            if (bond == null)
            {
                return NotFound();
            }

            return Ok(bond);
        }

        // Fetching Bond by Name
        [HttpGet("BondName")]
        public async Task<IActionResult> GetBondByName([FromQuery] string name)
        {
            var equity = await _bonds.GetBondByName(name);

            if (equity == null)
            {
                return NotFound();
            }

            return Ok(equity);
        }

        // Adding a new Bond
        [HttpPost("Add")]
        public async Task<IActionResult> PostBond([FromBody] Bond bond)
        {
            await _bonds.AddNewBond(bond);

            return CreatedAtAction("GetBond", new { id = bond.SecurityId, controller = "Bonds" }, bond);
        }


        // Updating Bond

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> PutEquity([FromRoute] int id, [FromBody] Bond bond)
        {
            if (id != bond.SecurityId)
            {
                return BadRequest();
            }

            var str = await _bonds.UpdateBondById(id, bond);

            if (str == null)
            {
                return BadRequest();
            }

            return Ok(str);
        }

        // Deleting a bond
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteEquity([FromRoute] int id)
        {
            var str = await _bonds.DeleteBondById(id);

            if (str == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        // Patching api
        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchBond(int id, [FromBody] JsonPatchDocument patch)
        {
            var result = await _bonds.UpdateSpecificBond(id, patch);

            if (result == "Bond not found")
            {
                return NotFound(result);
            }

            return NoContent(); // Successfully updated the bond
        }


    }
}
