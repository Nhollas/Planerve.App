using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Core.Features.FormFeatures.Dtos.FormSections
{
    public class EmploymentSectionDto
    {
        public bool IsEmploymentChanged { get; set; }
        public string ExistingFullTime { get; set; }
        public string ExistingPartTime { get; set; }
        public string ExistingTotalFullTimeEquivalent { get; set; }
        public string ProposedFullTime { get; set; }
        public string ProposedPartTime { get; set; }
        public string ProposedTotalFullTimeEquivalent { get; set; }
    }
}
