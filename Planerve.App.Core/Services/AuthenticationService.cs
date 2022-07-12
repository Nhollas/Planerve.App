using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Planerve.App.Core.Interfaces.Persistence;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Core.Models.Authentication;
using Planerve.App.Domain.Entities.AuthEntities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Planerve.App.Core.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly IUserRepository _userRepository;
    private readonly IConfiguration _configuration;

    public AuthenticationService(
        IUserRepository userRepository,
        IConfiguration configuration)
    {
        _userRepository = userRepository;
        _configuration = configuration;
    }

    public Task<string> Login(LoginRequest request)
    {
        bool loginExists = _userRepository.UserExists(request.Username);

        if (loginExists)
        {
            ApplicationUser userInfo = _userRepository.GetUser(request.Username);

            if (!VerifyPasswordHash(request.Password, userInfo.PassHash, userInfo.PassSalt))
            {
                throw new Exception("You have entered an invalid username or password");
            }

            string token = CreateToken(userInfo);

            return Task.FromResult(token);
        }
        throw new Exception("You have entered an invalid username or password");
    }

    public Task<RegistrationResponse> Register(RegistrationRequest request)
    {
        bool existingUser = _userRepository.EmailExists(request.Email);

        // If an existing user already exists, send fake message.
        if (existingUser)
        {
            throw new Exception("Thank you for registering, an email has been sent to this account for confirmation");
        }

        CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

        ApplicationUser user = new()
        {
            Email = request.Email,
            UserName = request.Username,
            PassHash = passwordHash,
            PassSalt = passwordSalt
        };

        var result = _userRepository.Register(user);

        RegistrationResponse response = new()
        {
            UserId = result.Id,
            Email = result.Email,
            Username = result.UserName
        };

        return Task.FromResult(response);
    }

    // TODO: Sort Refresh token handler out.

    private string CreateToken(ApplicationUser user)
    {
        List<Claim> claims = new()
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id),
            new Claim(ClaimTypes.Name, user.UserName)
        };

        var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
            _configuration.GetSection("Jwt:Key").Value));

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var token = new JwtSecurityToken(
            issuer: _configuration.GetSection("Jwt:Issuer").Value,
            audience: _configuration.GetSection("Jwt:Audience").Value,
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: creds);

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }

    private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        // TODO: Change this algo to another one like Argon2, bcrypt, scrypt, and PBKDF2

        using (var hmac = new HMACSHA512())
        {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }
    }

    private static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        // TODO: Change this algo to another one like Argon2, bcrypt, scrypt, and PBKDF2

        using (var hmac = new HMACSHA512(passwordSalt))
        {
            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            return computedHash.SequenceEqual(passwordHash);
        }
    }
}