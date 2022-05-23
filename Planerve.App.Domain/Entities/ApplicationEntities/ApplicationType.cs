using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Planerve.App.Domain.Entities.ApplicationEntities
{
    public class ApplicationType
    {
        [ForeignKey("ApplicationData")]
        [JsonIgnore]
        public Guid Id { get; set; }
        [JsonIgnore]
        public Application ApplicationData { get; set; }
        public int Value { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public string Description { get; set; }
        public int ApplicationCategory {  get; set; }
    }
}
