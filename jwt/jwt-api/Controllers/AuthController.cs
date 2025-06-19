using JWT.BL.Models;
using JWT.BL.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace jwt_api.Controllers;


[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IJWTService _service;

    public AuthController(IJWTService service)
    {
        _service = service;
    }

    [HttpPost("login")]
    [AllowAnonymous]
    public IActionResult Login(UserLogin userLogin)
    {
        // Validate user credentials (example only)
        if (userLogin.Username == "testuser" && userLogin.Password == "password123")
        {
            var token = _service.GenerateToken(userLogin.Username);
            return Ok(new { token });
        }

        return Unauthorized();
    }
}


