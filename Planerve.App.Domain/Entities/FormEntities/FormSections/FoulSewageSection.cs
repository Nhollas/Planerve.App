using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class FoulSewageSection : Disposal
    {
        public Guid Id { get; set; }
        public string OtherMethod { get; set; }
        public bool ConnectingToExistingDrainage { get; set; }
        public string DocumentReferences { get; set; }
    }

    public class Disposal
    {
        public bool MainsSewer { get; set; }
        public bool SepticTank { get; set; }
        public bool PackageTreatmentPlant { get; set; }
        public bool CessPit { get; set; }
        public bool Other { get; set; }
        public bool Unknown { get; set; }
    }
}
