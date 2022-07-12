using System;
namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class DischargeConditionSection
    {
        public Guid Id { get; set; }
        public bool DischargePartOnly { get; set; }
        public string PartsDescription { get; set; }
        public string SubmittedInformation { get; set; }
    }
}