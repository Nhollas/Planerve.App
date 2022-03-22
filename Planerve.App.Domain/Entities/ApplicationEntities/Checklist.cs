using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Planerve.App.Domain.Entities.ApplicationEntities
{
    public class Checklist
    {
        [ForeignKey("ApplicationData")]
        [JsonIgnore]
        public Guid Id { get; set; }

        [JsonIgnore]
        public Application ApplicationData { get; set; }

        public bool FormSections { get; set; }
        public bool PlansAndDocs { get; set; }
        public bool CalculatedFee { get; set; }
        public bool SubmittedToLocalAuthority { get; set; }

    }
}
