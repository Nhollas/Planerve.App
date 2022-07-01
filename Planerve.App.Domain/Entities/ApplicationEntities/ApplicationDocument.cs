using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Planerve.App.Domain.Entities.ApplicationEntities
{
    public class ApplicationDocument
    {
        [ForeignKey("Application")]
        [Column("ApplicationId")]
        public Guid Id { get; set; }
        [JsonIgnore]
        public Application Application { get; set; }

        public int DocumentCount { get; set; }
        public int CompletedRequirementsCount { get; set; }
        public int TotalRequirementCount { get; set; }
        public ICollection<DocumentRequirement> DocumentRequirements { get; set; }

        public class DocumentRequirement
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }
    }
}
