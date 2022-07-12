using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Core.Features.FormFeatures.Dtos.FormSections
{
    public class ProposalSectionDto
    {
        public string Description { get; set; }
        public bool HasStarted { get; set; }
        public DateTime StartDate { get; set; }
        public bool HasCompleted { get; set; }
        public DateTime CompletionDate { get; set; }
    }
}

