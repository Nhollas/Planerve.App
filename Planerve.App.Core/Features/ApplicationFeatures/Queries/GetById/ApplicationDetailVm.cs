using Planerve.App.Core.Features.ApplicationFeatures.Dtos;
using System;

namespace Planerve.App.Core.Features.ApplicationFeatures.Queries.GetApplicationById
{
    public class ApplicationDetailVm
    {
        public Guid Id { get; set; }
        public string ApplicationReference { get; set; }
        public string ApplicationName { get; set; }
        public string VersionNumber { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public ApplicationTypeDto Type { get; set; }
        public ApplicationDocumentDto Document { get; set; }
        public ApplicationProgressDto Progress { get; set; }
    }
}