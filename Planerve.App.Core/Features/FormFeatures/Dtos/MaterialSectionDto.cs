using System.Collections.Generic;

namespace Planerve.App.Core.Features.FormFeatures.Dtos
{
    public class MaterialSectionDto
    {
        public bool MaterialsRequired { get; set; }
        public ICollection<MaterialTypeDto> MaterialTypes { get; set; }
        public bool AdditionalInformation { get; set; }
        public string DocumentReference { get; set; }
    }
    public class MaterialTypeDto
    {
        public string Name { get; set; }
        public string ExistingMaterial { get; set; }
        public string ProposedMaterial { get; set; }
    }
}
