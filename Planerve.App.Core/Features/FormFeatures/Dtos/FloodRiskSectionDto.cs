namespace Planerve.App.Core.Features.FormFeatures.Dtos
{
    public class FloodRiskSectionDto
    {
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
