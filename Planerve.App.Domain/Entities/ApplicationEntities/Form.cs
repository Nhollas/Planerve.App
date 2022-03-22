using Planerve.App.Domain.Entities.FormEntities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Planerve.App.Domain.Entities.ApplicationEntities;

public class Form
{
    [ForeignKey("ApplicationData")]
    [JsonIgnore]
    public Guid Id { get; set; }
    [JsonIgnore]
    public Application ApplicationData { get; set; }
    public FormTypeOne FormTypeOneData { get; set; }
    public FormTypeTwo FormTypeTwoData { get; set; }
}