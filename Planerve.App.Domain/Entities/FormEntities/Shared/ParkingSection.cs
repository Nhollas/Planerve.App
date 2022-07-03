using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    [Owned]
    public class ParkingSection
    {
        public Guid Id { get; set; }
        public bool AffectingParking { get; set; }
        public string ParkingDescription{ get; set; }
    }
}
