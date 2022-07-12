using System;
using System.Collections.Generic;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class IndustrialMachinerySection
    {
        public Guid Id { get; set; }
        public string ProcessesAndProducts { get; set; }
        public bool DoesInvolveIndustrialCommercial { get; set; }
        public bool IsProposalWasteManagementDevelopment { get; set; }
        public ICollection<WasteManagementDetail> WasteManagementDetails { get; set; }
        public ICollection<WasteStreamDetail> WasteStreamDetails { get; set; }
    }

    public class WasteManagementDetail
    {
        public string WasteManagementType { get; set; }
        public string TotalVoidCapacityVolumeUnit { get; set; }
        public string MaxAnnualOperationalThroughputVolumeUnit { get; set; }
        public int TotalVoidCapacity { get; set; }
        public int MaxAnnualOperationalThroughput { get; set; }
    }

    public class WasteStreamDetail
    {
        public string WasteStreamType { get; set; }
        public string MaxAnnualOperationalThroughputVolumeUnit { get; set; }
        public int MaxAnnualOperationalThroughput { get; set; }
    }
}
