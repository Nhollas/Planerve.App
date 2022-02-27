namespace Planerve.App.UI.Contracts;

public interface IAuthService
{
    Task<bool> Register(string userName, string email, string password, string confirmPassword);
}