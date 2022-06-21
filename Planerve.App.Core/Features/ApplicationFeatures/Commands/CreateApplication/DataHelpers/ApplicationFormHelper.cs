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
        }

        public ApplicationForm GetFormInfo(int applicationType)
        {
            var applicationForm = new Dictionary<int, ApplicationForm>()
            {
                {   1,
                    new ApplicationForm {
                        FormSectionsComplete = false,
                        FormTitle = "Householder Application for Planning Permission for works or extension to a dwelling. Town and Country Planning Act 1990",
                        TotalSectionCount = 16,
                        CompletedSectionCount = 0,
                    }
                }
            };

            applicationForm.TryGetValue(applicationType, out var formInfo);

            return formInfo;
        }
    }
}