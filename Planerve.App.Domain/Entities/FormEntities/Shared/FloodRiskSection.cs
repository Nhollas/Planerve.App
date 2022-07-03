using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    [Owned]
    public class FloodRiskSection
    {
        public Guid Id { get; set; }
        public bool IsFloodRisk { get; set; }
        public bool ProximityOfWatercourse { get; set; }
        public bool IncreaseFloodRisk { get; set; }
        public bool SustainableDrainage { get; set; }
        public bool ExistingWaterCourse { get; set; }
        public bool Soakaway { get; set; }
        public bool MainSewer { get; set; }
        public bool PondLake { get; set; }
    }
}
