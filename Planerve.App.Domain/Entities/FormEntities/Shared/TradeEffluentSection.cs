using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    [Owned]
    public class TradeEffluentSection
    {
        public Guid Id { get; set; }
        public bool DisposeTradeWaste { get; set; }
        public bool TradeWasteDescription { get; set; }
    }
}
