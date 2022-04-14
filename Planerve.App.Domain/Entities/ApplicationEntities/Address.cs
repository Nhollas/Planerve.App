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
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string AddressLineThree { get; set; }
        public string postcode { get; set; }
        public int quality { get; set; }
        public int eastings { get; set; }
        public int northings { get; set; }
        public string country { get; set; }
        public string nhs_ha { get; set; }
        public float longitude { get; set; }
        public float latitude { get; set; }
        public string european_electoral_region { get; set; }
        public string primary_care_trust { get; set; }
        public string region { get; set; }
        public string lsoa { get; set; }
        public string msoa { get; set; }
        public string incode { get; set; }
        public string outcode { get; set; }
        public string parliamentary_constituency { get; set; }
        [Column("administrative_district")]
        public string admin_district { get; set; }
        public string parish { get; set; }
        [Column("administrative_county")]
        public string admin_county { get; set; }
        [Column("administrative_ward")]
        public string admin_ward { get; set; }
        public string ced { get; set; }
        public string ccg { get; set; }
        public string nuts { get; set; }
    }
}
