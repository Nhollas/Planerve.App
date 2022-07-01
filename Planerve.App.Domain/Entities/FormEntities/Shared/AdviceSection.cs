using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class AdviceSection
    {
        [Required]
        public string Name { get; set; } = "Advice";
    }
}
