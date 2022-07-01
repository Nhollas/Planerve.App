using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class EmploymentSection
    {
        [Required]
        public string Name { get; set; }
    }
}
