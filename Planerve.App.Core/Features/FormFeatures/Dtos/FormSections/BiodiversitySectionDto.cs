using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Core.Features.FormFeatures.Dtos.FormSections
{
    public class BiodiversitySectionDto
    {
        public int ProtectedSpecies { get; set; }
        public int DesignatedSite { get; set; }
        public int FeaturesOfGeological { get; set; }

    }
}
