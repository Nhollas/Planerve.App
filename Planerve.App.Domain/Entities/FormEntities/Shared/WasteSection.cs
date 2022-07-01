using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class WasteSection
    {
        [Required]
        public string Name { get; set; } = "Waste";
    }
}
