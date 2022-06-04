using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planerve.App.Domain.Entities.ApplicationEntities
{
    public class ApplicationForm
    {
        [ForeignKey("ApplicationData")]
        [Column("ApplicationId")]
        public Guid Id { get; set; }
        public ApplicationData ApplicationData { get; set; }

        public string FormTitle { get; set; }
        public bool FormSectionsComplete { get; set; }
        public int TotalSectionCount { get; set; }
        public int CompletedSectionCount { get; set; }
        public ICollection<FormSection> FormSections { get; set; }

        public class FormSection
        {
            public string SectionName { get; set; }
            public ICollection<FormField> FormFields { get; set; }
        }

        public class FormField
        {
            public string FieldName { get; set; }
            public string FieldType { get; set; }
        }
    }
}
