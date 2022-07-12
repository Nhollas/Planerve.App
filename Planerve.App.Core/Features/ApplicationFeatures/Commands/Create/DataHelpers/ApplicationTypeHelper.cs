using System.Collections.Generic;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.Create.DataHelpers
{
    public static class ApplicationTypeHelper
    {
        public class ApplicationType
        {
            public int Value { get; set; }
            public string Name { get; set; }
            public string Group { get; set; }
            public string Description { get; set; }
            public string CategoryName { get; set; }
            public string CategoryDescription { get; set; }
            public int CategoryValue { get; set; }
        }

        public class ApplicationCategory
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public int Value { get; set; }
        }

        public static ApplicationType GetTypeInfo(int applicationType, int applicationCategory)
        {
            var applicationTypes = new Dictionary<int, ApplicationType>()
            {
                {   1,
                    new ApplicationType{
                        Value = 1,
                        Name = "Householder planning permission",
                        Group = "Householder planning & prior approval",
                        Description = "An application for an alteration to an existing house such as extensions, conservatories, loft conversions or outbuildings. This does not include flats.",
                    }
                },
                {
                    2,
                    new ApplicationType{
                        Value = 2,
                        Name = "Full planning permission",
                        Group = "Full planning",
                        Description = "A detailed planning application for development, excluding work to an existing house. Also used to apply for 'technical details consent' on a site that has been granted 'permission in principle'. This can also be used for any work to a flat."
                    }
                },
                {   3,
                    new ApplicationType{
                        Value = 3,
                        Name = "Approval of details reserved by a condition (Discharge)",
                        Group = "Existing consents",
                        Description = "This application will be needed when a condition in a planning permission needs more information on a specific aspect of the development to be approved (discharged) by the Local Planning Authority."
                    }
                },
                {   4,
                    new ApplicationType{
                        Value = 4,
                        Name = "Non-Material Amendment",
                        Group = "Existing consents",
                        Description = "Use this application if you want to make a small change to an existing planning permission. This could be something that doesn't alter the development or breach any planning policies."
                    }
                },
                {   5,
                    new ApplicationType{
                        Value = 5,
                        Name = "Removal/Variation of a condition",
                        Group = "Existing consents",
                        Description = "Use this application to request that the Local Planning Authority removes or changes the requirements of a condition after planning permission has been given."
                    }
                }
            };

            var applicationCategories = new Dictionary<int, ApplicationCategory>()
            {
                {
                    1,
                    new ApplicationCategory{
                        Name = "Standard Application",
                        Description = "default",
                        Value = 1

                    }
                },
                {
                    2,
                    new ApplicationCategory{
                        Name = "Waste Management",
                        Description = "Select this if your application covers some form of waste management e.g. Industrial, storage or distribution of waste. If selected, your application will be sent to the County Council and not the Local Planning Authority.",
                        Value = 2
                    }
                },
                {
                    3,
                    new ApplicationCategory{
                        Name = "Regulation 3",
                        Description = "Select where a Local Authority (or someone on their behalf) will carry out the work or if your Local Authority has a significant interest in your development. If selected, your application will be sent to the County Council and not the Local Planning Authority.",
                        Value = 3
                    }
                },
            };

            applicationTypes.TryGetValue(applicationType, out var typeInfo);
            applicationCategories.TryGetValue(applicationCategory, out var categoryInfo);

            typeInfo.CategoryName = categoryInfo.Name;
            typeInfo.CategoryDescription = categoryInfo.Description;
            typeInfo.CategoryValue = categoryInfo.Value;

            return typeInfo;
        }
    }
}
