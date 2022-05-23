namespace Planerve.App.UI.Models
{
    public class ApplicationFilterModel
    {
        public string SearchQuery { get; set; }
        public string VersionNumber { get; set; }
        public List<ApplicationType> ApplicationTypes { get; set; }
        public List<LocalPlanningAuthority> LocalPlanningAuthorities { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }

        public class ApplicationType
        {
            public int Value { get; set; }
            public string Name { get; set; }
        }

        public class LocalPlanningAuthority
        {
            public int Value { get; set; }
            public string Name { get; set; }
        }

    }
}
