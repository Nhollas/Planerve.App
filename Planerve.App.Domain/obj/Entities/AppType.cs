using ApplciationPortal.Domain.Common;
using System;
using System.Collections.Generic;

namespace ApplciationPortal.Domain.Entities
{
    public class AppType: AuditableEntity
    {
        public Guid TypeId { get; set; }
        public string Name { get; set; }
    }
}
