using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class FloodRiskSection
    {
        [Required]
        public string Name { get; set; } = "Flood Risk";
    }
}
