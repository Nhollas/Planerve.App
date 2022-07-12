using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class TreeAndHedgeSection
    {
        public Guid Id { get; set; }
        public bool FallingTreesHedge { get; set; }
        public string FallingTreeHedgeReference { get; set; }
        public bool TreeHedgeRemoved { get; set; }
        public string TreeHedgeRemovedReference { get; set; }
    }
}


