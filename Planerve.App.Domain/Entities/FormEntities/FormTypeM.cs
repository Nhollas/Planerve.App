using System;
using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities
{
    public class FormTypeM
    {
        [Key]
        public Guid FormId { get; set; }
        public Guid ApplicationId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string OwnerId { get; set; }
    }
}
