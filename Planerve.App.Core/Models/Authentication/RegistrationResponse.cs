namespace Planerve.App.Core.Models.Authentication;

public class RegistrationResponse
{
    public string UserId { get; set; }
    public string Email { get; set; }
    public string Username { get; set; } = string.Empty;
}