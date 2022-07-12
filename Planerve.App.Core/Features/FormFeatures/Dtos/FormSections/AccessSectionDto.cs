using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Core.Features.FormFeatures.Dtos.FormSections
{
    public class AccessSectionDto
    {
        public bool NewVehicleAccess { get; set; }
        public bool NewAlteredPedestrianAccess { get; set; }
        public bool AffectingRightOfWay { get; set; }
        public string DrawingReferenceNumbers { get; set; }
    }
}
