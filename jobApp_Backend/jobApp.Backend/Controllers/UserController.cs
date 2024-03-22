using jobApp.Backend.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace jobApp.Backend.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public UserController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest registerRequest)
    {
        _authenticationService.Register(registerRequest);
        return Ok("test");
    }

    [HttpPost("login")]
    public void Login(LoginRequest loginRequest)
    {
        _authenticationService.Login(loginRequest);
    }
}