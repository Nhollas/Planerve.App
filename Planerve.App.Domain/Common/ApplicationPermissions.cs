namespace Planerve.App.Domain.Common
{
    public class ApplicationPermissions
    {
        // Application Access
        public bool ReadApplication { get; set; }
        public bool CopyApplication { get; set; }

        // Form Access
        public bool CreateForm { get; set; }
        public bool ReadForm { get; set; }
        public bool EditForm { get; set; }
        public bool DownloadForm { get; set; }

        // File Access

        // TODO: Create File Access Permissions

    }
}
