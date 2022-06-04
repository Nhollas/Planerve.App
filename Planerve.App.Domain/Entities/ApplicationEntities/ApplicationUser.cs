using Planerve.App.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planerve.App.Domain.Entities.ApplicationEntities
{
    public class ApplicationUser : ApplicationPermissions
    {
        [ForeignKey("ApplicationData")]
        [Column("ApplicationId")]
        public Guid Id { get; set; }
        public ApplicationData ApplicationData { get; set; }

        public string UserId { get; set; }
        public string AccessLevel { get; set; }
        public bool IsValid { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
