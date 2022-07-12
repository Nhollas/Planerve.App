using System.Collections.Generic;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.Create.DataHelpers
{
    public static class ApplicationDocumentHelper
    {
        public class ApplicationDocument
        {
            public int DocumentCount { get; set; }
            public int CompletedRequirementsCount { get; set; }
            public int TotalRequirementCount { get; set; }
            public ICollection<DocumentRequirement> DocumentRequirements { get; set; }
        }
        public class DocumentRequirement
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }

        public static ApplicationDocument GetDocumentInfo(int applicationType)
        {
            var locationPlanRequirement = new DocumentRequirement()
            {
                Name = "Location plan",
                Description = "Your application requires a plan identifying the land to which it relates. The site should be outlined in red. The plan should: be drawn to an identified scale; show the direction of North; and contain sufficient detail (e.g. road names) to define the location."
            };

            var plansAndDrawingsRequirement = new DocumentRequirement()
            {
                Name = "Plans and drawings",
                Description = "Sufficient plans and drawings (e.g. site/block plans, elevations, sections) are required to describe the subject of your application. All plans should be drawn to an identified scale. Where relevant, they should show existing and/or proposed features and details."
            };

            var designAndAccessStatementRequirement = new DocumentRequirement()
            {
                Name = "Design and access statement",
                Description = "This should be a concise report explaining how the proposed development is a suitable response to the site and its setting and demonstrating that it can be adequately accessed by prospective users."
            };

            var sitePlanRequirement = new DocumentRequirement()
            {
                Name = "Site/Block Plan Proposed",
                Description = "Your application requires at least one plan indicating the site and showing the proposed development. The plan(s) should be drawn to an identified scale and show the direction of North."
            };

            var verificationOfApplicationEvidenceRequirement = new DocumentRequirement()
            {
                Name = "Verification of application Evidence",
                Description = "The information in your application (i.e. work, dates, uses, grounds) must be sufficiently evidenced (e.g. with plans/drawings, declarations/affidavits/registrations, bills/receipts/invoices) to allow the Local Authority to verify it. If you cannot provide such evidence, please state why this is the case."
            };

            var sketchPlanRequirement = new DocumentRequirement()
            {
                Name = "Sketch plan",
                Description = "Your application requires at least one sketch plan. For applications/notifications for tree works, this should show and reference the relevant trees (and any other trees on the site) as well as boundaries and adjoining properties (including house numbers or names), names of roads, and the direction of North."
            };

            var applicationChecklists = new Dictionary<int, ApplicationDocument>()
            {
                { 1,
                    new ApplicationDocument
                    {
                        DocumentCount = 0,
                        CompletedRequirementsCount = 0,
                        TotalRequirementCount = 2,
                        DocumentRequirements = new List<DocumentRequirement>()
                        {
                            plansAndDrawingsRequirement,
                            locationPlanRequirement
                        }
                    }
                },
                { 2,
                    new ApplicationDocument
                    {
                        DocumentCount = 0,
                        CompletedRequirementsCount = 0,
                        TotalRequirementCount = 3,
                        DocumentRequirements = new List<DocumentRequirement>()
                        {
                            plansAndDrawingsRequirement,
                            locationPlanRequirement,
                            designAndAccessStatementRequirement
                        }
                    }
                },
                { 3,
                    new ApplicationDocument
                    {
                        DocumentCount = 0,
                        CompletedRequirementsCount = 0,
                        TotalRequirementCount = 3,
                        DocumentRequirements = new List<DocumentRequirement>()
                        {
                            plansAndDrawingsRequirement,
                            locationPlanRequirement,
                            designAndAccessStatementRequirement
                        }
                    }
                },
                { 4,
                    new ApplicationDocument
                    {
                        DocumentCount = 0,
                        CompletedRequirementsCount = 0,
                        TotalRequirementCount = 1,
                        DocumentRequirements = new List<DocumentRequirement>()
                        {
                            sitePlanRequirement
                        }
                    }
                },
                { 5,
                    new ApplicationDocument
                    {
                        DocumentCount = 0,
                        CompletedRequirementsCount = 0,
                        TotalRequirementCount = 1,
                        DocumentRequirements = new List<DocumentRequirement>()
                        {
                            sitePlanRequirement
                        }
                    }
                },
                { 6,
                    new ApplicationDocument
                    {
                        DocumentCount = 0,
                        CompletedRequirementsCount = 0,
                        TotalRequirementCount = 2,
                        DocumentRequirements = new List<DocumentRequirement>()
                        {
                            locationPlanRequirement,
                            plansAndDrawingsRequirement
                        }
                    }
                },
                { 7,
                    new ApplicationDocument
                    {
                        DocumentCount = 0,
                        CompletedRequirementsCount = 0,
                        TotalRequirementCount = 3,
                        DocumentRequirements = new List<DocumentRequirement>()
                        {
                            locationPlanRequirement,
                            plansAndDrawingsRequirement,
                            designAndAccessStatementRequirement
                        }
                    }
                },
                { 8,
                    new ApplicationDocument
                    {
                        DocumentCount = 0,
                        CompletedRequirementsCount = 0,
                        TotalRequirementCount = 3,
                        DocumentRequirements = new List<DocumentRequirement>()
                        {
                            locationPlanRequirement,
                            plansAndDrawingsRequirement,
                            designAndAccessStatementRequirement
                        }
                    }
                },
                { 9,
                    new ApplicationDocument
                    {
                        DocumentCount = 0,
                        CompletedRequirementsCount = 0,
                        TotalRequirementCount = 2,
                        DocumentRequirements = new List<DocumentRequirement>()
                        {
                            locationPlanRequirement,
                            plansAndDrawingsRequirement
                        }
                    }
                },
                { 10,
                    new ApplicationDocument
                    {
                        DocumentCount = 0,
                        CompletedRequirementsCount = 0,
                        TotalRequirementCount = 2,
                        DocumentRequirements = new List<DocumentRequirement>()
                        {
                            locationPlanRequirement,
                            plansAndDrawingsRequirement
                        }
                    }
                },
                { 11,
                    new ApplicationDocument
                    {
                        DocumentCount = 0,
                        CompletedRequirementsCount = 0,
                        TotalRequirementCount = 2,
                        DocumentRequirements = new List<DocumentRequirement>()
                        {
                            locationPlanRequirement,
                            plansAndDrawingsRequirement
                        }
                    }
                },
                { 12,
                    new ApplicationDocument
                    {
                        DocumentCount = 0,
                        CompletedRequirementsCount = 0,
                        TotalRequirementCount = 2,
                        DocumentRequirements = new List<DocumentRequirement>()
                        {
                            locationPlanRequirement,
                            plansAndDrawingsRequirement
                        }
                    }
                },
                { 13,
                    new ApplicationDocument
                    {
                        DocumentCount = 0,
                        CompletedRequirementsCount = 0,
                        TotalRequirementCount = 0,
                        DocumentRequirements = new List<DocumentRequirement>()
                    }
                },
                { 14,
                    new ApplicationDocument
                    {
                        DocumentCount = 0,
                        CompletedRequirementsCount = 0,
                        TotalRequirementCount = 1,
                        DocumentRequirements = new List<DocumentRequirement>()
                        {
                            plansAndDrawingsRequirement
                        }
                    }
                },
                { 15,
                    new ApplicationDocument
                    {
                        DocumentCount = 0,
                        CompletedRequirementsCount = 0,
                        TotalRequirementCount = 0,
                        DocumentRequirements = new List<DocumentRequirement>()
                    }
                },
                { 16,
                    new ApplicationDocument
                    {
                        DocumentCount = 0,
                        CompletedRequirementsCount = 0,
                        TotalRequirementCount = 2,
                        DocumentRequirements = new List<DocumentRequirement>()
                        {
                            locationPlanRequirement,
                            verificationOfApplicationEvidenceRequirement
                        }
                    }
                },
                { 17,
                    new ApplicationDocument
                    {
                        DocumentCount = 0,
                        CompletedRequirementsCount = 0,
                        TotalRequirementCount = 2,
                        DocumentRequirements = new List<DocumentRequirement>()
                        {
                            locationPlanRequirement,
                            verificationOfApplicationEvidenceRequirement
                        }
                    }
                },
                { 18,
                    new ApplicationDocument
                    {
                        DocumentCount = 0,
                        CompletedRequirementsCount = 0,
                        TotalRequirementCount = 3,
                        DocumentRequirements = new List<DocumentRequirement>()
                        {
                            locationPlanRequirement,
                            plansAndDrawingsRequirement,
                            designAndAccessStatementRequirement
                        }
                    }
                },
                { 19,
                    new ApplicationDocument
                    {
                        DocumentCount = 0,
                        CompletedRequirementsCount = 0,
                        TotalRequirementCount = 2,
                        DocumentRequirements = new List<DocumentRequirement>()
                        {
                            locationPlanRequirement,
                            plansAndDrawingsRequirement
                        }
                    }
                },
                { 20,
                    new ApplicationDocument
                    {
                        DocumentCount = 0,
                        CompletedRequirementsCount = 0,
                        TotalRequirementCount = 1,
                        DocumentRequirements = new List<DocumentRequirement>()
                        {
                            sketchPlanRequirement
                        }
                    }
                }
            };

            applicationChecklists.TryGetValue(applicationType, out var checklistInfo);

            return checklistInfo;
        }
    }
}
