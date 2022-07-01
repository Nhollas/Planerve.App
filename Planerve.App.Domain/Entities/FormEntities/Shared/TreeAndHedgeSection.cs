using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class TreeAndHedgeSection
    {
        [Required]
        public string Name { get; set; } = "Tree And Hedge";
    }
}


