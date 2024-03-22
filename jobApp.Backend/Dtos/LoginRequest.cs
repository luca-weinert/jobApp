using System.ComponentModel.DataAnnotations;

namespace jobApp.Backend.Dtos;

public class LoginRequest
{
    [Required]
    public string? Username { get; set; }
    
    [Required]
    public string? Password { get; set; }
}