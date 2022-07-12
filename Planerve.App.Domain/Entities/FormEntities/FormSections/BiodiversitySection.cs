using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class BiodiversitySection
    {
        public Guid Id { get; set; }
        public int ProtectedSpecies { get; set; }
        public int DesignatedSite { get; set; }
        public int FeaturesOfGeological { get; set; }

    }
}
