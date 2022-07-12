using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Core.Features.FormFeatures.Dtos.FormSections
{
    public class WasteSectionDto
    {
        public bool StoreCollectWaste { get; set; }
        public string StoreCollectWasteDetails { get; set; }
        public bool StoreCollectRecyclableWaste { get; set; }
        public string StoreCollectRecyclableWasteDetails { get; set; }
    }
}
