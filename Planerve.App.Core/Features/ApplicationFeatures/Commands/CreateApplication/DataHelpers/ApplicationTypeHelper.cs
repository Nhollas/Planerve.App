using System.Collections.Generic;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.CreateApplication.DataHelpers
{
    public class ApplicationTypeHelper
    {
        public class ApplicationType
        {
            public int Value { get; set; }
            public string Name { get; set; }
            public string Group { get; set; }
            public string Description { get; set; }
            public string CategoryName { get; set; }
            public string CategoryDescription { get; set; }
        }

        public class ApplicationCategory
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }

        public ApplicationType GetTypeInfo(int applicationType, int applicationCategory)
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
                {   2,
                    new ApplicationType{
                        Value = 2,
                        Name = "Householder planning & demolition in a conservation area",
                        Group = "Householder planning & prior approval",
                        Description = "An application for an alteration to an existing house within a conservation area that involves substantial demolition. Types of alterations could be extensions, conservatories, loft conversions or outbuildings. This does not include flats."
                    }
                },
                {
                    3,
                    new ApplicationType{
                        Value = 3,
                        Name = "Householder planning & listed building consent",
                        Group = "Householder planning & prior approval",
                        Description = "An application for alterations, extensions, or demolition to a existing house that is a listed building. Types of alterations could be extensions, conservatories, loft conversions or outbuildings. This does not include flats."
                    }
                },
                {
                    4,
                    new ApplicationType{
                        Value = 4,
                        Name = "Prior Approval: Larger home extension",
                        Group = "Householder planning & prior approval",
                        Description = "This application is specifically for a proposed 'larger' single storey rear extension to a house(over 4m up to 8m for detached houses, over 3m up to 6m for all other houses), to determine if prior approval is required from the Local Planning Authority. It assesses certain aspects of the proposed permitted development and the impact they will have."
                    }
                },
                {
                    5,
                    new ApplicationType{
                        Value = 5,
                        Name = "Prior Approval: Additional storeys on a dwellinghouse",
                        Group = "Householder planning & prior approval",
                        Description = "This application is for the prior approval of an extension of a home with additional storeys. It assesses certain aspects of the proposed permitted development and the impact they will have."
                    }
                },
                {
                    6,
                    new ApplicationType{
                        Value = 6,
                        Name = "Full planning permission",
                        Group = "Full planning",
                        Description = "A detailed planning application for development, excluding work to an existing house. Also used to apply for 'technical details consent' on a site that has been granted 'permission in principle'. This can also be used for any work to a flat."
                    }
                },
                {   7,
                    new ApplicationType{
                        Value = 7,
                        Name = "Full planning planning & demolition in a conservation area",
                        Group = "Full planning",
                        Description = "A detailed planning application for development, excluding work to an existing house, within a conservation area that involves substantial demolition. This can also be used for any work to a flat."
                    }
                },
                {   8,
                    new ApplicationType{
                        Value = 8,
                        Name = "Full planning planning & listed building consent",
                        Group = "Full planning",
                        Description = "A detailed planning application for development, excluding work to an existing house, that affects the character of a listed building. Also used to apply for 'technical details consent' on a site that has been granted 'permission in principle'. This can also be used for any work to a flat."
                    }
                },
                {   9,
                    new ApplicationType{
                        Value = 9,
                        Name = "Full planning planning & display of advertisements",
                        Group = "Full planning",
                        Description = "A detailed planning application for development, excluding work to an existing house, along with the display of an advertisement.Also used to apply for 'technical details consent' on a site that has been granted 'permission in principle'. This can also be used for any work to a flat."
                    }
                },
                {   10,
                    new ApplicationType{
                        Value = 10,
                        Name = "Outline planning permission: Some matters reserved",
                        Group = "Outline planning",
                        Description ="An application for outline planning permission aims to establish whether a proposed development would likely be acceptable to the Local Planning Authority, before a full details are put forward. Matters such as appearance, access, landscaping, layout and scale can be reserved for later determination."
                    }
                },
                {   11,
                    new ApplicationType{
                        Value = 11,
                        Name = "Outline planning permission: All matters reserved",
                        Group = "Outline planning",
                        Description = "An application for outline planning permission aims to establish whether a proposed development would likely to be acceptable to the Local Planning Authority, before full details are put forward. All matters of appearance, access, landscaping, layout and scale are reserved for later determination."
                    }
                },
                {   12,
                    new ApplicationType{
                        Value = 12,
                        Name = "Approval of reserved matters",
                        Group = "Existing consents",
                        Description = "After receiving outline planning permission, you will need to provide full details of anything that was left out of the original application (the reserved matters). Use this application to provide details of any or all reserved matters following outline planning permission."
                    }
                },
                {   13,
                    new ApplicationType{
                        Value = 13,
                        Name = "Approval of details reserved by a condition (Discharge)",
                        Group = "Existing consents",
                        Description = "This application will be needed when a condition in a planning permission needs more information on a specific aspect of the development to be approved (discharged) by the Local Planning Authority."
                    }
                },
                {   14,
                    new ApplicationType{
                        Value = 14,
                        Name = "Non-Material Amendment",
                        Group = "Existing consents",
                        Description = "Use this application if you want to make a small change to an existing planning permission. This could be something that doesn't alter the development or breach any planning policies."
                    }
                },
                {   15,
                    new ApplicationType{
                        Value = 15,
                        Name = "Removal/Variation of a condition",
                        Group = "Existing consents",
                        Description = "Use this application to request that the Local Planning Authority removes or changes the requirements of a condition after planning permission has been given."
                    }
                },
                {   16,
                    new ApplicationType{
                        Value = 16,
                        Name = "Lawful development: Existing use",
                        Group = "Lawful development certificate",
                        Description = "If you want to confirm that an existing use or an operation that has been carried out is lawful for planning purposes, you can apply for a Lawful Development Certificate. This can also be used to confirm the lawfulness of any matter that does not comply with a previously imposed planning condition."
                    }
                },
                {   17,
                    new ApplicationType{
                        Value = 17,
                        Name = "Lawful development: Proposed use",
                        Group = "Lawful development certificate",
                        Description = "If you want to ensure that any proposed use or operation is lawful for planning purposes or that your proposal does not require planning permission, you can apply for a Lawful Development Certificate."
                    }
                },
                {   18,
                    new ApplicationType{
                        Value = 18,
                        Name = "Listed building consent",
                        Group = "Other consents",
                        Description = "An application for the alteration, extension, demolition, or any other works that affect the character of a listed building."
                    }
                },
                {   19,
                    new ApplicationType{
                        Value = 49,
                        Name = "Consent to display an advertisement",
                        Group = "Other consents",
                        Description = "An application for the display of advertisements."
                    }
                },
                {   20,
                    new ApplicationType{
                        Value = 20,
                        Name = "Tree works: Trees in conservation areas/subject to TPOs",
                        Group = "Other consents",
                        Description = "An application for works to trees that are under a Tree Preservation Order (TPO) and/or notification of proposed tree works within a conservation area."
                    }
                },
            };

            applicationTypes.TryGetValue(applicationType, out var typeInfo);

            var applicationCategories = new Dictionary<int, ApplicationCategory>()
            {
                {
                    1,
                    new ApplicationCategory{
                        Name = "Standard Application",
                        Description = null
                    }
                },
                {
                    2,
                    new ApplicationCategory{
                        Name = "Waste Management",
                        Description = "Select this if your application covers some form of waste management e.g. Industrial, storage or distribution of waste. If selected, your application will be sent to the County Council and not the Local Planning Authority."
                    }
                },
                {
                    3,
                    new ApplicationCategory{
                        Name = "Regulation 3",
                        Description = "Select where a Local Authority (or someone on their behalf) will carry out the work or if your Local Authority has a significant interest in your development. If selected, your application will be sent to the County Council and not the Local Planning Authority."
                    }
                },
            };

            applicationCategories.TryGetValue(applicationCategory, out var categoryInfo);

            typeInfo.CategoryName = categoryInfo.Name;
            typeInfo.CategoryDescription = categoryInfo.Description;

            return typeInfo;
        }
    }
}
