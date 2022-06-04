using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planerve.App.Domain.Entities.ApplicationEntities
{
    public class ApplicationType
    {
        [ForeignKey("ApplicationData")]
        [Column("ApplicationId")]
        public Guid Id { get; set; }
        public ApplicationData ApplicationData { get; set; }

        public int Value { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public string Description { get; set; }
        public ApplicationCategory Category { get; set; }

        public class ApplicationCategory
        {
            public string Name  { get; set; }
            public string Description { get; set; }
        }
    }
}
