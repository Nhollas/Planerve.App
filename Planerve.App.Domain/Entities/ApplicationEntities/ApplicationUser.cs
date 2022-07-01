using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Planerve.App.Domain.Entities.ApplicationEntities
{
    public class ApplicationUser
    {
        [ForeignKey("Application")]
        [Column("ApplicationId")]
        public Guid Id { get; set; }
        [JsonIgnore]
        public Application Application { get; set; }
        public string OwnerId { get; set; }
        public ICollection<AuthorisedUser> AuthorisedUsers { get; set; }
    }
    public class AuthorisedUser : ApplicationPermissions
    {
        public Guid Id { get; set; }
        public Guid ApplicationId { get; set; }
        public string UserId { get; set; }
        public bool IsValid { get; set; }
        public DateTime ExpiryDate { get; set; }
    }

    public class ApplicationPermissions
    {
        public bool EditPermission { get; set; }
        public bool ReadApplication { get; set; }
        public bool DeleteApplication { get; set; }
        public bool CopyApplication { get; set; }
        public bool ArchiveApplication { get; set; }
        public bool ShareApplication { get; set; }
        public bool ReadForm { get; set; }
        public bool UpdateForm { get; set; }
        public bool DownloadForm { get; set; }
    }
}
