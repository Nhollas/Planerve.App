using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Core.Models.Authentication;

public class RegistrationRequest
{

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [MinLength(6)]
    public string UserName { get; set; }

    [Required]
    [MinLength(6)]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}