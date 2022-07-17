using Planerve.App.Domain.Common;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System;
using System.Collections.Generic;

namespace Planerve.App.Domain.Entities.ProjectEntities
{
    public class Project : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Application> Applications { get; set; }
    }
}
