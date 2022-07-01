using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class OpeningHoursSection
    {
        [Required]
        public string Name { get; set; }
    }
}
