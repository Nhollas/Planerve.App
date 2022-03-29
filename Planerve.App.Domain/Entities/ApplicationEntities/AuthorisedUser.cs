using System;

namespace Planerve.App.Domain.Entities.ApplicationEntities
{
    public class AuthorisedUser
    {
        public Guid Id { get; set; }
        public Guid ApplicationId { get; set; }
        public string UserId { get; set; }
        public string TokenUsed { get; set; }
        public DateTime ImportedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsValid { get; set; }
    }
}
