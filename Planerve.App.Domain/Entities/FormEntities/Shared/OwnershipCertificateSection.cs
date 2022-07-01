using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class OwnershipCertificationSection
    {
        [Required]
        public string Name { get; set; } = "Ownership Certificates";
    }
}
