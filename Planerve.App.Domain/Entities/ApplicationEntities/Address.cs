using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Planerve.App.Domain.Entities.ApplicationEntities
{
    public class Address
    {
        [ForeignKey("ApplicationData")]
        [JsonIgnore]
        public Guid Id { get; set; }
        [JsonIgnore]
        public Application ApplicationData { get; set; }
        public string Postcode { get; set; }
        public string LocalAuthority { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string AddressLineThree { get; set; }
        public string FullAddress => AddressLineOne + AddressLineTwo + AddressLineThree;
    }
}
