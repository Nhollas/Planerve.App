namespace Planerve.App.UI.ViewModels.ApplicationVMs
{
    public class FormDetailViewModel
    {
        public Guid Id { get; set; }
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
            public string FieldTarget { get; set; }
            public string Name { get; set; }
            public string Label { get; set; }
            public string FieldType { get; set; }
            public string ClassName { get; set; }
            public string Text { get; set; }
            public string ValidationAttributes { get; set; }
            public ICollection<Option> Options { get; set; }
        }

        public class Option
        {
            public int Value { get; set; }
            public string ClassName { get; set; }
            public string Label { get; set; }
            public string OptionName { get; set; }
        }
    }
}
