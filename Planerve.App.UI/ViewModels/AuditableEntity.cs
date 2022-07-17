namespace Planerve.App.UI.ViewModels
{
    public class AuditableEntity
    {
        public string Owner { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
