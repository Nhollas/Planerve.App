using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class OpeningHoursSection
    {
        public Guid Id { get; set; }
        public bool IsRelevant { get; set; }
        public ICollection<UseClass> UseClasses { get; set; }

    }

    public class UseClass
    { 
        public int Type { get; set; }
        public bool IsKnown { get; set; }
        public DateTimeOffset MtoFStart { get; set; }
        public DateTimeOffset MtoFEnd { get; set; }
        public DateTimeOffset SaturdayStart { get; set; }
        public DateTimeOffset SaturdayEnd { get; set; }
        public DateTimeOffset SpecialStart { get; set; }
        public DateTimeOffset SpecialEnd { get; set; }
    }
}
