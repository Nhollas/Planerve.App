using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    [Owned]
    public class ExistingUseSection
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
