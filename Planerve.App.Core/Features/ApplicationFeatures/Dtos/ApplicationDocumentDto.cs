using System;
using System.Collections.Generic;

namespace Planerve.App.Core.Features.ApplicationFeatures.Dtos
{
    public class ApplicationDocumentDto
    {
        public Guid Id { get; set; }
        public int DocumentCount { get; set; }
        public int CompletedRequirementsCount { get; set; }
        public int TotalRequirementCount { get; set; }
        public ICollection<DocumentRequirementDto> DocumentRequirements { get; set; }
    }
}
