using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class ExistingUseSection
    {
        [Required]
        public string Name { get; set; }
    }
}
