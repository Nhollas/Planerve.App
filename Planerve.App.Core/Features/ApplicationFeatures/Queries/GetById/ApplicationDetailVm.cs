using Planerve.App.Domain.Entities.ApplicationEntities;
using System;

namespace Planerve.App.Core.Features.ApplicationFeatures.Queries.GetApplicationById
{
    public class ApplicationDetailVm
    {
        public Guid AppId { get; set; }
        public string AppReference { get; set; }
        public string AppName { get; set; }
        public string AppVersion { get; set; }
        public string AppStatus { get; set; }
        public int AppType { get; set; }
        public int AppCategory { get; set; }
        public int PercentageComplete { get; set; }
        public string Owner { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public Submission Submission { get; set; }
    }
}