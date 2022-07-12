using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class ConditionProposalSection
    {
        public Guid Id { get; set; }
        public string ApprovedDescription { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTimeOffset DecisionDate { get; set; }
        public string ConditionNumbers { get; set; }
        public bool HasStarted { get; set; }
        public DateTime StartedDate { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CompletedDate { get; set; }
    }
}
