using System.Collections.Generic;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.CreateApplication.DataHelpers
{
    public class ApplicationFormHelper
    {
        public class ApplicationForm
        {
            public string FormTitle { get; set; }
            public bool FormSectionsComplete { get; set; }
            public int TotalSectionCount { get; set; }
            public int CompletedSectionCount { get; set; }
            public ICollection<FormSection> FormSections { get; set; }
        }

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

        public FormField TextBox(string fieldName)
        {

            var textBox = new FormField()
            {
                FieldName = fieldName,
                FieldType = "TextBox",
            };

            return textBox;
        }

        public ApplicationForm GetFormInfo (int applicationType)
        {
            var applicationForm = new Dictionary<int, ApplicationForm>()
            {
                {   1,
                    new ApplicationForm{
                        FormSectionsComplete = false,
                        FormTitle = "Householder Application for Planning Permission for works or extension to a dwelling. Town and Country Planning Act 1990",
                        TotalSectionCount = 16,
                        CompletedSectionCount = 0,
                        FormSections = new List<FormSection>()
                        {
                            new FormSection()
                            {
                                SectionName = "Applicant Info",
                                FormFields = new List<FormField>()
                                {
                                    TextBox("Title"),
                                    TextBox("First Name"),
                                    TextBox("Last Name"),
                                }
                               
                            }
                        }
                    }
                }
            };

            applicationForm.TryGetValue(applicationType, out var formInfo);

            return formInfo;
        }
    }
}

// TODO: Finish this Dictionary.
