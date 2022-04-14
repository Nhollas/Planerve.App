using Planerve.App.Domain.Entities.ApplicationEntities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Planerve.App.Domain.Entities.FormEntities
{
    public class FormTypeTwo
    {
        [ForeignKey("FormData")]
        public Guid Id { get; set; }

        [JsonIgnore]
        public Form FormData { get; set; }

        public string PropertyNumber { get; set; }
        public string BuildingSuffix { get; set; }
        public string PropertyName { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string AddressThree { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
        public string EastingValue { get; set; }
        public string NorthingValue { get; set; }
        public string SiteDescription { get; set; }
    }
}
