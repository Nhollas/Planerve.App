using MediatR;
using System;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.Share
{
    public class ShareApplicationCommand : IRequest
    {
        public Guid ApplicationId { get; set; }
        public string UsernameOrEmail { get; set; }
        public bool EditPermission { get; set; }
        public bool ReadApplication { get; set; }
        public bool DeleteApplication { get; set; }
        public bool CopyApplication { get; set; }
        public bool ArchiveApplication { get; set; }
        public bool ShareApplication { get; set; }
        public bool ReadForm { get; set; }
        public bool UpdateForm { get; set; }
        public bool DownloadForm { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
