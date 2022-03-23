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

        // What level of access does this token give.
        public int TokenAccessLevel { get; set; }

        // User that owns this token.
        public string OwnerId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastAccessedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsExpired { get; set; }
    }
}
