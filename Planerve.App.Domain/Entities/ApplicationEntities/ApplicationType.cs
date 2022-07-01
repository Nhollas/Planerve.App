using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Planerve.App.Domain.Entities.ApplicationEntities
{
    public class ApplicationType
    {
        [ForeignKey("Application")]
        [Column("ApplicationId")]
        public Guid Id { get; set; }
        [JsonIgnore]
        public Application Application { get; set; }

        public int Value { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public int CategoryValue { get; set; }
    }
}
