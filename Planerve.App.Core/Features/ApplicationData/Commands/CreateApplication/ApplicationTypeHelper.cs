using System.Collections.Generic;

namespace Planerve.App.Core.Features.ApplicationData.Commands.CreateApplication
{
    public class ApplicationTypeHelper
    {
        public class ApplicationType
        {
            public int Value { get; set; }
            public string Name { get; set; }
            public string Group { get; set; }
            public string Description { get; set; }
        }

        public ApplicationType GetTypeInfo(int applicationType)
        {
            var applicationTypes = new Dictionary<int, ApplicationType>()
            {
               {    1, 
                    new ApplicationType{ 
                        Value = 1,
                        Name = "Householder planning & prior approval planning permission", 
                        Group = "Householder planning & prior approval planning & prior approval",
                        Description = "An application for an alteration to an existing house such as extensions, conservatories, loft conversions or outbuildings. This does not include flats."
                    } 
               },
               {    2, 
                    new ApplicationType{ 
                        Value = 2, 
                        Name = "Householder planning & prior approval planning & demolition in a conservation area", 
                        Group = "Householder planning & prior approval",
                        Description = "An application for an alteration to an existing house within a conservation area that involves substantial demolition.Types of alterations could be extensions, conservatories, loft conversions or outbuildings. This does not include flats."
                    } 
                },
               { 
                    3, 
                    new ApplicationType{ 
                        Value = 3, 
                        Name = "Householder planning & prior approval planning & listed building consent", 
                        Group = "Householder planning & prior approval",
                        Description = "An application for an alteration to an existing house within a conservation area that involves substantial demolition.Types of alterations could be extensions, conservatories, loft conversions or outbuildings. This does not include flats."
                    }
                },
                {
                    4,
                    new ApplicationType{
                        Value = 4,
                        Name = "Prior Approval: Larger homoe extension",
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
                        Name = "Full planning planning permission", 
                        Group = "Full planning",
                        Description = "A detailed planning application for development, excluding work to an existing house. Also used to apply for 'technical details consent' on a site that has been granted 'permission in principle'. This can also be used for any work to a flat."
                    } 
                },
               { 7, 
                    new ApplicationType{ 
                        Value = 7, 
                        Name = "Full planning planning & demolition in a conservation area", 
                        Group = "Full planning",
                        Description = "A detailed planning application for development, excluding work to an existing house, within a conservation area that involves substantial demolition. This can also be used for any work to a flat."
                    } 
                },
               { 8, 
                    new ApplicationType{ 
                        Value = 8, 
                        Name = "Full planning planning & listed building consent", 
                        Group = "Full planning",
                        Description = "A detailed planning application for development, excluding work to an existing house, that affects the character of a listed building.Also used to apply for 'technical details consent' on a site that has been granted 'permission in principle'. This can also be used for any work to a flat."
                    } 
                },
               { 9, 
                    new ApplicationType{ 
                        Value = 9, 
                        Name = "Full planning planning & display of advertisements", 
                        Group = "Full planning",
                        Description = "A detailed planning application for development, excluding work to an existing house, along with the display of an advertisement.Also used to apply for 'technical details consent' on a site that has been granted 'permission in principle'. This can also be used for any work to a flat."
                    } 
                },
               { 10, new ApplicationType{ Value = 10, Name = "Outline planning permission: Some matters reserved", Group = "Outline planning" } },
               { 11, new ApplicationType{ Value = 11, Name = "Outline planning permission: All matters reserved", Group = "Outline planning" } },
               { 12, new ApplicationType{ Value = 12, Name = "Approval of reserved matters", Group = "Existing consents" } },
               { 13, new ApplicationType{ Value = 13, Name = "Removal/Variation of a condition", Group = "Existing consents" } },
               { 14, new ApplicationType{ Value = 14, Name = "Approval of details reserved by a condition (Discharge)", Group = "Existing consents" } },
               { 15, new ApplicationType{ Value = 15, Name = "Non-Material Amendment", Group = "Existing consents" } },
               { 16, new ApplicationType{ Value = 16, Name = "Lawful development: Existing use", Group = "Lawful development certificate" } },
               { 17, new ApplicationType{ Value = 17, Name = "Lawful development: Proposed use", Group = "Lawful development certificate" } },
               { 18, new ApplicationType{ Value = 18, Name = "Prior Approval: Change of use - commercial/business/service to dwellinghouses", Group = "Prior Approval - Changes of use" } },
               { 19, new ApplicationType{ Value = 19, Name = "Prior Approval: Change of use - commercial/business/service/etc to mixed use including up to two flats", Group = "Prior Approval - Changes of use" } },
               { 20, new ApplicationType{ Value = 20, Name = "Prior Approval: Change of use - retail/service/etc to assembly/leisure", Group = "Prior Approval - Changes of use" } },
               { 21, new ApplicationType{ Value = 21, Name = "Prior Approval: Change of use - takeaway/sui generis/mixed use to dwellinghouses", Group = "Prior Approval - Changes of use" } },
               { 22, new ApplicationType{ Value = 22, Name = "Prior Approval: Change of use - retail/service/takeaway/etc to offices", Group = "Prior Approval - Changes of use" } },
               { 23, new ApplicationType{ Value = 23, Name = "Prior Approval: Change of use - agriculture to dwellinghouses", Group = "Prior Approval - Changes of use" } },
               { 24, new ApplicationType{ Value = 24, Name = "Prior Approval: Change of use - agriculture to flexible commercial use", Group = "Prior Approval - Changes of use" } },
               { 25, new ApplicationType{ Value = 25, Name = "Prior Approval: Change of use - agriculture to state-funded school", Group = "Prior Approval - Changes of use" } },
               { 26, new ApplicationType{ Value = 26, Name = "Prior Approval: Change of use - commercial/business/service/hotel/etc to state-funded school", Group = "Prior Approval - Changes of use" } },
               { 27, new ApplicationType{ Value = 27, Name = "Prior Approval: Change of use - amusements/casinos to dwellinghouses", Group = "Prior Approval - Changes of use" } },
               { 28, new ApplicationType{ Value = 28, Name = "Prior Approval: New flats on top of detached blocks of flats", Group = "Prior Approval - New dwellinghouses" } },
               { 29, new ApplicationType{ Value = 29, Name = "Prior Approval: New flats on top of detached commercial buildings", Group = "Prior Approval - New dwellinghouses" } },
               { 30, new ApplicationType{ Value = 30, Name = "Prior Approval: New flats on top of terraced commercial buildings", Group = "Prior Approval - New dwellinghouses" } },
               { 31, new ApplicationType{ Value = 31, Name = "Prior Approval: New flats on top of detached dwellinghouses", Group = "Prior Approval - New dwellinghouses" } },
               { 32, new ApplicationType{ Value = 32, Name = "Prior Approval: Demolish and replace with building used as dwellinghouses", Group = "Prior Approval - New dwellinghouses" } },
               { 33, new ApplicationType{ Value = 33, Name = "Prior Approval: Development for electronic communications network", Group = "Prior Approval - Other new development" } },
               { 34, new ApplicationType{ Value = 34, Name = "Prior Approval: Building for agricultural/forestry use", Group = "Prior Approval - Other new development" } },
               { 35, new ApplicationType{ Value = 35, Name = "Prior Approval: Private road for agricultural/forestry use", Group = "Prior Approval - Other new development" } },
               { 36, new ApplicationType{ Value = 36, Name = "Prior Approval: Excavation/Deposit waste for agriculture", Group = "Prior Approval - Other new development" } },
               { 37, new ApplicationType{ Value = 37, Name = "Prior Approval: Tank/Cage/Structure for use in fish farming", Group = "Prior Approval - Other new development" } },
               { 38, new ApplicationType{ Value = 38, Name = "Prior Approval: Collection facility for a shop", Group = "Prior Approval - Other new development" } },
               { 39, new ApplicationType{ Value = 39, Name = "Prior Approval: Roof mounted solar PV on non-domestic building", Group = "Prior Approval - Other new development" } },
               { 40, new ApplicationType{ Value = 40, Name = "Prior Approval: Erection, extension, or alteration of a university building", Group = "Prior Approval - Other new development" } },
               { 41, new ApplicationType{ Value = 41, Name = "Prior Approval: Movable structure for historic visitor attraction, or listed pub/restaurant/etc", Group = "Prior Approval - Other new development" } },
               { 42, new ApplicationType{ Value = 42, Name = "Prior Approval: Single living accommodation/Non-residential buildings on a closed defence site", Group = "Prior Approval - Other new development" } },
               { 43, new ApplicationType{ Value = 43, Name = "Prior Approval: Temporary school on previously vacant commercial land", Group = "Prior Approval - Temporary use" } },
               { 44, new ApplicationType{ Value = 44, Name = "Prior Approval: Temporary use for commercial film-making", Group = "Prior Approval - Temporary use" } },
               { 45, new ApplicationType{ Value = 45, Name = "Prior Approval: Demolition of building", Group = "Prior Approval - Demolition" } },
               { 46, new ApplicationType{ Value = 46, Name = "Demolition in a conservation area", Group = "Other consents" } },
               { 47, new ApplicationType{ Value = 47, Name = "Listed building consent", Group = "Other consents" } },
               { 48, new ApplicationType{ Value = 48, Name = "Consent to display an advertisement", Group = "Other consents" } },
               { 49, new ApplicationType{ Value = 49, Name = "Hedgerow removal notice", Group = "Other consents" } },
               { 50, new ApplicationType{ Value = 50, Name = "Tree works: Trees in conservation areas/subject to TPOs", Group = "Other consents" } },
            };

            applicationTypes.TryGetValue(applicationType, out var typeInfo);

            return typeInfo;
        }
    }
}
