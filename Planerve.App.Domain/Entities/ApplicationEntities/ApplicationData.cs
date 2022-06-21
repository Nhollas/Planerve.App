using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Planerve.App.Domain.Entities.ApplicationEntities
{
    public class ApplicationData
    {
        [ForeignKey("Application")]
        [Column("ApplicationId")]
        public Guid Id { get; set; }
        [JsonIgnore]
        public Application Application { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }
        public ApplicationType Type { get; set; }
        public ApplicationAddress Address { get; set; }
        public ApplicationDocument Document { get; set; }
        public ApplicationProgress Progress { get; set; }
    }
}
