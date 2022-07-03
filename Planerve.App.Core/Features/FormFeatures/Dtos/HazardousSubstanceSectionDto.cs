using System.Collections.Generic;

namespace Planerve.App.Core.Features.FormFeatures.Dtos
{
    public class HazardousSubstanceSectionDto
    {
        public bool InvolvesHazardousSubstances { get; set; }
        public ICollection<SubstanceDto> Substances { get; set; }
    }

    public class SubstanceDto
    {
        public string Name { get; set; }
        public int Amount { get; set; }
    }
}
