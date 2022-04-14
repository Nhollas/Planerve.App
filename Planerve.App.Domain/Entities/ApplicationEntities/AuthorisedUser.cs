using Planerve.App.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.ApplicationEntities
{
    public class AuthorisedUser : ApplicationPermissions
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ApplicationId { get; set; }
        public string UserId { get; set; }
        public string Role { get; set; }
        public bool IsValid { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
