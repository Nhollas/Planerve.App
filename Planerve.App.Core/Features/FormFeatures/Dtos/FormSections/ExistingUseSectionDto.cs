using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Core.Features.FormFeatures.Dtos.FormSections
{
    public class ExistingUseSectionDto
    {
        public Guid Id { get; set; }
        public string CurrentUseDescription { get; set; }
        public bool IsVacant { get; set; }
        public string LastUseDescription { get; set; }
        public DateTime UseEnded { get; set; }
        public bool LandToBeContaminated { get; set; }
        public bool PartLandToBeContaminated { get; set; }
        public bool UseSusceptibleToContamination { get; set; }
    }
}
