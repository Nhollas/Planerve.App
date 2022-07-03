using System;

namespace Planerve.App.Core.Features.FormFeatures.Dtos
{
    public class AccessSectionDto
    {
        public Guid Id { get; set; }
        public bool NewVehicleAccess { get; set; }
        public bool NewAlteredPedestrianAccess { get; set; }
        public bool AffectingRightOfWay { get; set; }
        public string DrawingReferenceNumbers { get; set; }
    }
}
