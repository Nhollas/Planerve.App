using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Core.Features.FormFeatures.Dtos.FormSections
{
    public class TreeAndHedgeSectionDto
    {
        public bool FallingTreesHedge { get; set; }
        public string FallingTreeHedgeReference { get; set; }
        public bool TreeHedgeRemoved { get; set; }
        public string TreeHedgeRemovedReference { get; set; }
    }
}


