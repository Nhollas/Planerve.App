using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class AccessSection
    {
        [Required]
        public string Name { get; set; } = "Access";
    }
}
