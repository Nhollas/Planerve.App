using Microsoft.AspNetCore.Identity;
using System;

namespace Planerve.App.Domain.Entities.AuthEntities
{
    public class ApplicationUser : IdentityUser
    {
        public byte[] PassHash { get; set; }
        public byte[] PassSalt { get; set; }
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime TokenCreated { get; set; }
        public DateTime TokenExpires { get; set; }
    }
}
