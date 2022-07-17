using System;
using System.ComponentModel.DataAnnotations;
using Planerve.App.Domain.Common;

namespace Planerve.App.Domain.Entities.ApplicationEntities
{
    public class Submission : AuditableEntity
    {
        [Key]
        public Guid SubmissionId { get; set; } = Guid.NewGuid();
        public int FormType { get; set; }
        public string TypeName { get; set; }
        public string CategoryName { get; set; }
        public string TypeDescription { get; set; }
        public Guid FormId { get; set; } = Guid.NewGuid();
    }
}
