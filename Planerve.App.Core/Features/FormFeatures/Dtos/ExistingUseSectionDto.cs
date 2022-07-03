using System;

namespace Planerve.App.Core.Features.FormFeatures.Dtos
{
    public class ExistingUseSectionDto
    {
        public string CurrentUseDescription { get; set; }
        public bool IsVacant { get; set; }
        public string LastUseDescription { get; set; }
        public DateTime UseEnded { get; set; }
        public bool LandToBeContaminated { get; set; }
        public bool PartLandToBeContaminated { get; set; }
        public bool UseSusceptibleToContamination { get; set; }
    }
}
