using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Login.Models;

[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly LoginCredentialsContext _context;

    public UsersController(LoginCredentialsContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Authorize(Roles = "Admin")]  // Only Admins can access this
    public IActionResult GetUsers()
    {
        return Ok(_context.Users.ToList());
    }
}
