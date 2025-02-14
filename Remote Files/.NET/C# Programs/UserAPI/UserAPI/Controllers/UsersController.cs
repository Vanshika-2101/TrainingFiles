using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using UserAPI.UserRepo;

namespace UserAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUser _user;

        public UsersController(IUser user)
        {
            _user = user;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _user.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetUserById([FromRoute] int id)
        {
            var users = await _user.GetUserByIdAsync(id);
            if (users == null)
            {
                return NotFound();
            }
            return Ok(users);
        }

        [HttpPost("Post")]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            await _user.AddUserAsync(user);
            return CreatedAtAction(nameof(GetUserById), new {id = user.Id, controller = "Users"}, user);
            //return Ok("User added successfully");
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            await _user.DeleteUserAsync(id);
            return Ok("User deleted successfully");
        }


        [HttpPut("Put/{id}")]
        public async Task<IActionResult> UpdateUser([FromRoute] int id, [FromBody] User user)
        {
            if(id != user.Id)
            {
                return BadRequest();
            }
            await _user.UpdateUserAsync(user);
            return NoContent();
        }

    }
}
