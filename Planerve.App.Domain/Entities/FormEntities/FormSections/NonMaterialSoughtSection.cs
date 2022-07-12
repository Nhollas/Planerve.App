using System;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class NonMaterialSoughtSection
    {
        public Guid Id { get; set; }
        public string MaterialDescription { get; set; }
        public string MaterialReason { get; set; }
        public bool SubstitutePlans { get; set; }
        public string OldDrawingNumbers { get; set; }
        public string NewDrawingNumbers { get; set; }
    }
}
