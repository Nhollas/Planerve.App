using System;
using System.Collections.Generic;

namespace Planerve.App.Core.Features.FormFeatures.Dtos.FormSections
{
    public class IndustrialMachinerySectionDto
    {
        public string ProcessesAndProducts { get; set; }
        public bool DoesInvolveIndustrialCommercial { get; set; }
        public bool IsProposalWasteManagementDevelopment { get; set; }
        public ICollection<WasteManagementDetailDto> WasteManagementDetails { get; set; }
        public ICollection<WasteStreamDetailDto> WasteStreamDetails { get; set; }
    }

    public class WasteManagementDetailDto
    {
        public string WasteManagementType { get; set; }
        public string TotalVoidCapacityVolumeUnit { get; set; }
        public string MaxAnnualOperationalThroughputVolumeUnit { get; set; }
        public int TotalVoidCapacity { get; set; }
        public int MaxAnnualOperationalThroughput { get; set; }
    }

    public class WasteStreamDetailDto
    {
        public string WasteStreamType { get; set; }
        public string MaxAnnualOperationalThroughputVolumeUnit { get; set; }
        public int MaxAnnualOperationalThroughput { get; set; }
    }
}
