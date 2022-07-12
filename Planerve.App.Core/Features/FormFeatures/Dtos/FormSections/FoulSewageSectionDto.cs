using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Core.Features.FormFeatures.Dtos.FormSections
{
    public class FoulSewageSectionDto : DisposalDto
    {
        public string OtherMethod { get; set; }
        public bool ConnectingToExistingDrainage { get; set; }
        public string DocumentReferences { get; set; }
    }

    public class DisposalDto
    {
        public bool MainsSewer { get; set; }
        public bool SepticTank { get; set; }
        public bool PackageTreatmentPlant { get; set; }
        public bool CessPit { get; set; }
        public bool Other { get; set; }
        public bool Unknown { get; set; }
    }
}
