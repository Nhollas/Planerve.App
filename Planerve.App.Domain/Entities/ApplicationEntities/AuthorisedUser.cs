using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Planerve.App.Domain.Entities.ApplicationEntities
{
    public class AuthorisedUser
    {
        [ForeignKey("ApplicationData")]
        [JsonIgnore]
        public Guid Id { get; set; }

        [JsonIgnore]
        public Application ApplicationData { get; set; }

        public string UserId { get; set; }
    }
}
