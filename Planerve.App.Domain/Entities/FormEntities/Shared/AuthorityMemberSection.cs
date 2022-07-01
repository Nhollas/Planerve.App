using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class AuthorityMemberSection
    {
        [Required]
        public string Name { get; set; } = "Local Authority";
    }
}
