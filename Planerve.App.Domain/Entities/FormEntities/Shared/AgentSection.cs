using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class AgentSection
    {
        [Required]
        public string Name { get; set; } = "Agent";
    }
}
