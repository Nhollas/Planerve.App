using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Core.Features.FormFeatures.Dtos.FormSections
{
    public class TradeEffluentSectionDto
    {
        public bool DisposeTradeWaste { get; set; }
        public bool TradeWasteDescription { get; set; }
    }
}
