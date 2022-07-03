using System;
using System.Collections.Generic;

namespace Planerve.App.Core.Features.FormFeatures.Dtos
{
    public class OpeningHoursSectionDto
    {
        public bool IsRelevant { get; set; }
        public ICollection<UseClassDto> UseClasses { get; set; }

    }

    public class UseClassDto
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
