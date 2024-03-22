using jobApp.Backend.Dtos;

namespace jobApp.Backend.Controllers;

public class AuthenticationService : IAuthenticationService
{
    public Task<string> Register(RegisterRequest registerRequest)
    {
        return null;
    }

    public Task<string> Login(LoginRequest loginRequest)
    {
        throw new NotImplementedException();
    }
}