using System.Collections.Generic;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.Create.DataHelpers
{
    public static class SubmissionHelper
    {
        public class Submission
        {
            public int FormType { get; set; }
            public string TypeName { get; set; }
            public string CategoryName { get; set; }
            public string TypeDescription { get; set; }
        }

        public static Submission GetSubmissionInfo(int applicationType, int applicationCategory)
        {
            Dictionary<int, Submission> typeDict = new()
            {
                {   1,
                    new Submission{
                        FormType = 1,
                        TypeName = "Householder Planning Permission",
                        TypeDescription = "An application for an alteration to an existing house such as extensions, conservatories, loft conversions or outbuildings. This does not include flats.",
                    }
                },
                {
                    2,
                    new Submission{
                        FormType = 2,
                        TypeName = "Full Planning Permission",
                        TypeDescription = "A detailed planning application for development, excluding work to an existing house. Also used to apply for 'technical details consent' on a site that has been granted 'permission in principle'. This can also be used for any work to a flat."
                    }
                },
                {   3,
                    new Submission{
                        FormType = 3,
                        TypeName = "Approval of details reserved by a condition (Discharge)",
                        TypeDescription = "This application will be needed when a condition in a planning permission needs more information on a specific aspect of the development to be approved (discharged) by the Local Planning Authority."
                    }
                },
                {   4,
                    new Submission{
                        FormType = 4,
                        TypeName = "Non-Material Amendment",
                        TypeDescription = "Use this application if you want to make a small change to an existing planning permission. This could be something that doesn't alter the development or breach any planning policies."
                    }
                },
                {   5,
                    new Submission{
                        FormType = 5,
                        TypeName = "Removal/Variation of a condition",
                        TypeDescription = "Use this application to request that the Local Planning Authority removes or changes the requirements of a condition after planning permission has been given."
                    }
                }
            };

            Dictionary<int, string> categoryDict = new()
            {
                {
                    1,
                    "Standard Application"
                },
                {
                    2,
                    "Waste Management"
                },
                {
                    3,
                    "Regulation 3"
                }
            };

            typeDict.TryGetValue(applicationType, out var typeInfo);
            categoryDict.TryGetValue(applicationCategory, out var categoryInfo);

            typeInfo.CategoryName = categoryInfo;

            return typeInfo;
        }
    }
}
