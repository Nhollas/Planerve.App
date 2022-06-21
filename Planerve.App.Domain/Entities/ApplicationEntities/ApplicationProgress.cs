using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Planerve.App.Domain.Entities.ApplicationEntities
{
    public class ApplicationProgress
    {
        [ForeignKey("ApplicationData")]
        [Column("ApplicationId")]
        public Guid Id { get; set; }
        [JsonIgnore]
        public ApplicationData ApplicationData { get; set; }

        public string ApplicationStatus { get; set; }
        public int ProgressPercentage { get; set; }
        public bool FormSectionsComplete { get; set; }
        public bool PlansAndDocsComplete { get; set; }
        public bool CalculatedFee { get; set; }
        public bool SubmittedToLocalAuthority { get; set; }
    }
}
