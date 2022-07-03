using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    [Owned]
    public class ProposalSection
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool HasStarted { get; set; }
        public DateTime StartDate { get; set; }
        public bool HasCompleted { get; set; }
        public DateTime CompletionDate { get; set; }
    }
}

