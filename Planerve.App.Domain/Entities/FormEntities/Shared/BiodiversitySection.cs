using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class BiodiversitySection
    {
        [Required]
        public string Name { get; set; }
    }
}
