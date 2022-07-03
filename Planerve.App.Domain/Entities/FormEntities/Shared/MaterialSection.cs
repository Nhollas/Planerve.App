using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class MaterialSection
    {
        public Guid Id { get; set; }
        public bool MaterialsRequired { get; set; }
        public ICollection<MaterialType> MaterialTypes { get; set; }
        public bool AdditionalInformation { get; set; }
        public string DocumentReference { get; set; }
    }
    public class MaterialType
    {
        public string Name { get; set; }
        public string ExistingMaterial { get; set; }
        public string ProposedMaterial { get; set; }
    }
}
