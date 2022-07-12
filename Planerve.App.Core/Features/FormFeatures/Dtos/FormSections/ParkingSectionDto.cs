using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Core.Features.FormFeatures.Dtos.FormSections
{
    public class ParkingSectionDto
    {
        public bool AffectingParking { get; set; }
        public string ParkingDescription{ get; set; }
    }
}
