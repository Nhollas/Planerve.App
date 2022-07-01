using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class ParkingSection
    {
        [Required]
        public string Name { get; set; } = "Parking";
    }
}

