using System;
using System.Collections.Generic;

namespace Planerve.App.Core.Features.FormFeatures.Queries.GetFormById;

public class FormDetailVm
{
    public Guid Id { get; set; }
    public string FormTitle { get; set; }
    public bool FormSectionsComplete { get; set; }
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