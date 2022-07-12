using System;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class VariationConditionSection
    {
        public Guid Id { get; set; }
        public string ChangeOrRemovalReason { get; set; }
        public string ChangeDescription { get; set; }
    }
}
