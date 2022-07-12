using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class EmploymentSection
    {
        public Guid Id { get; set; }
        public bool IsEmploymentChanged { get; set; }
        public string ExistingFullTime { get; set; }
        public string ExistingPartTime { get; set; }
        public string ExistingTotalFullTimeEquivalent { get; set; }
        public string ProposedFullTime { get; set; }
        public string ProposedPartTime { get; set; }
        public string ProposedTotalFullTimeEquivalent { get; set; }
    }
}
