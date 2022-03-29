using System;
using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.ApplicationEntities
{
    public class AccessToken
    {

        [Key]
        public Guid Id { get; set; }
        public Guid ApplicationId { get; set; }
        public string Token { get; set; }
        public bool IsValid { get; set; }

        // User that owns this token.
        public string TokenHolderId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUsedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsExpired { get; set; }
        public int TokenUses { get; set; }
    }
}
