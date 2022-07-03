namespace Planerve.App.Core.Features.FormFeatures.Dtos
{
    public class FoulSewageSectionDto
    {
        public string OtherMethod { get; set; }
        public bool ConnectingToExistingDrainage { get; set; }
        public string DocumentReferences { get; set; }
        public bool MainsSewer { get; set; }
        public bool SepticTank { get; set; }
        public bool PackageTreatmentPlant { get; set; }
        public bool CessPit { get; set; }
        public bool Other { get; set; }
        public bool Unknown { get; set; }
    }
}
