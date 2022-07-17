using Planerve.App.Domain.Entities.ApplicationEntities;

namespace Planerve.App.Core.UnitTests.DataStores
{
    public static class ApplicationDataStore
    {
        public static List<Application> Applications
        {
            get
            {
                return new List<Application>()
                {
                    new Application
                    {
                        // This Id is mentioned in the CopyApplication test.
                        AppId = Guid.Parse("1ecbe7b0-1c82-450b-a186-ad916dd6614c"),
                        AppReference = "PP-123456789",
                        AppName = "FirstApp",
                        AppVersion = "V1",
                        AppStatus = "Draft",
                        AppType = 1,
                        AppCategory = 1,
                        PercentageComplete = 7,
                        // This Id is mentioned in the UserService moq.
                        Owner = "TestUserId",
                        Submission = new Submission
                        {
                            // This Id is set for the CopyApplication test.
                            SubmissionId = Guid.Parse("b94722c3-47ac-461e-9286-60e0c8945d4c"),
                            FormId = Guid.Parse("0a07f547-8dc7-4990-adf0-0150b6ed6c35"),
                            FormType = 1,
                            TypeName = "Householder Planning Permission",
                            TypeDescription = "An application for an alteration to an existing house such as extensions, conservatories, loft conversions or outbuildings. This does not include flats.",
                            CategoryName = "Standard Application"
                        }
                    },
                    new Application
                    {
                        AppId = Guid.Parse("a1ff8ccd-5a69-4c7d-bca6-dbba706f979c"),
                        AppReference = "PP-987654321",
                        AppName = "FirstApp",
                        AppVersion = "V1",
                        AppStatus = "Draft",
                        AppType = 3,
                        AppCategory = 1,
                        PercentageComplete = 7,
                        Submission = new Submission
                        {
                            FormType = 3,
                            TypeName = "Approval of details reserved by a condition (Discharge)",
                            TypeDescription = "This application will be needed when a condition in a planning permission needs more information on a specific aspect of the development to be approved (discharged) by the Local Planning Authority.",
                            CategoryName = "Standard Application"
                        }
                    },
                    new Application
                    {
                        AppId = Guid.Parse("4e9a244e-8177-4cc5-9898-af74b6799e12"),
                        AppReference = "PP-123459876",
                        AppName = "FirstApp",
                        AppVersion = "V1",
                        AppStatus = "Draft",
                        AppType = 5,
                        AppCategory = 3,
                        PercentageComplete = 7,
                        Submission = new Submission
                        {
                            FormType = 5,
                            TypeName = "Removal/Variation of a condition",
                            TypeDescription = "Use this application to request that the Local Planning Authority removes or changes the requirements of a condition after planning permission has been given.",
                            CategoryName = "Regulation 3"
                        }
                    }
                };
            }
        }
    }
}
