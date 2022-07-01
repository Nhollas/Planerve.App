using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class MaterialSection
    {
        [Required]
        public string Name { get; set; }
    }
}
