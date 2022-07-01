using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class SiteSection
    {
        [Required]
        public string Name { get; set; } = "Site";
    }
}

