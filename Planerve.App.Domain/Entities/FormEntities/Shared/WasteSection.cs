using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    [Owned]
    public class WasteSection
    {
        public Guid Id { get; set; }
        public bool StoreCollectWaste { get; set; }
        public string StoreCollectWasteDetails { get; set; }
        public bool StoreCollectRecyclableWaste { get; set; }
        public string StoreCollectRecyclableWasteDetails { get; set; }

    }
}
