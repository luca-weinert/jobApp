using jobApp.Backend.Dtos;

namespace jobApp.Backend.Controllers;

public interface IAuthenticationService
{
    Task<string> Register(RegisterRequest registerRequest);

    Task<string> Login(LoginRequest loginRequest);
}