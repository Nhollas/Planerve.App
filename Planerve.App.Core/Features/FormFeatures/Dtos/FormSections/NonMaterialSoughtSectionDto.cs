using System;

namespace Planerve.App.Core.Features.FormFeatures.Dtos.FormSections
{
    public class NonMaterialSoughtSectionDto
    {
        public string MaterialDescription { get; set; }
        public string MaterialReason { get; set; }
        public bool SubstitutePlans { get; set; }
        public string OldDrawingNumbers { get; set; }
        public string NewDrawingNumbers { get; set; }
    }
}
