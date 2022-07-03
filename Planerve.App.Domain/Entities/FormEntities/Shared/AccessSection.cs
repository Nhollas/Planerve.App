using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    [Owned]
    public class AccessSection
    {
        public Guid Id { get; set; }
        public bool NewVehicleAccess { get; set; }
        public bool NewAlteredPedestrianAccess { get; set; }
        public bool AffectingRightOfWay { get; set; }
        public string DrawingReferenceNumbers { get; set; }
    }
}
