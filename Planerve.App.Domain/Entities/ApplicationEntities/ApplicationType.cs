using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Planerve.App.Domain.Entities.ApplicationEntities;

public class ApplicationType
{
    public int Value { get; set; }
    public string Text { get; set; }
    public List<SelectListItem> ApplicationTypes { get; set; }

    public void OnGet()
    {
        var householder = new SelectListGroup { Name = "Householder Planning"};
        var full = new SelectListGroup { Name = "Full Planning"};
        var outline = new SelectListGroup { Name = "Outline Planning"};
        var existing = new SelectListGroup { Name = "Existing Consents"};
        var lawfulDevelopment = new SelectListGroup { Name = "Lawful Development Certificate"};
        var priorApprovalCou = new SelectListGroup { Name = "Prior Approval - Change of Use"};
        var priorApprovalNew = new SelectListGroup { Name = "Prior Approval - New Development"};
        var priorApprovalTu = new SelectListGroup { Name = "Prior Approval - Temporary Use"};
        var priorApprovalDem = new SelectListGroup { Name = "Prior Approval - Demolition"};
        var other = new SelectListGroup { Name = "Other Consents"};
        var comingSoon = new SelectListGroup{ Name = "Coming Soon"};

        ApplicationTypes = new List<SelectListItem>
        {
            new SelectListItem{ Value = "1", Text = "Householder planning permission", Group = householder },
            new SelectListItem{ Value = "2", Text = "Householder planning & demolition in a conservation area", Group = householder },
            new SelectListItem{ Value = "3", Text = "Householder planning & listed building consent", Group = householder },
            new SelectListItem{ Value = "4", Text = "Full planning permission", Group = full },
            new SelectListItem{ Value = "5", Text = "Full planning & demolition in a conservation area", Group = full },
            new SelectListItem{ Value = "6", Text = "Full planning & listed building consent", Group = full },
            new SelectListItem{ Value = "7", Text = "Full planning & display of advertisements", Group = full },
            new SelectListItem{ Value = null, Text = "Outline planning permission: Some matters reserved", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Outline planning permission: All matters reserved", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Approval of reserved matters", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Removal/Variation of a condition", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Approval of details reserved by a condition", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Non-Material Amendment", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Lawful development: Existing use", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Lawful development: Proposed use", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "[No longer valid] Prior Approval: Change of use - retail to restaurant/café", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "[Limited validity] Prior Approval: Change of use - retail to assembly/leisure", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Prior Approval: Change of use - agriculture to dwellinghouses", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Prior Approval: Change of use - agriculture to flexible commercial use", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Prior Approval: Change of use - agriculture to school/nursery", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Prior Approval: Change of use - business/hotels/etc to school/nursery", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Prior Approval: Change of use - offices to dwellinghouses", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Prior Approval: Change of use - light industrial to dwellinghouses", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Prior Approval: Change of use - amusements/casinos to dwellinghouses", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Prior Approval: Change of use - retail/takeaway to offices", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Prior Approval: Building for agricultural/forestry use", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Prior Approval: Private road for agricultural/forestry use", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Prior Approval: Excavation/Deposit waste for agriculture", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Prior Approval: Tank/Cage/Structure for use in fish farming", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Prior Approval: Development for electronic communications network", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Prior Approval: Larger Home Extension", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Prior Approval: Collection facility for a shop", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Prior Approval: Roof mounted solar PV on non-domestic building", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Prior Approval: Temporary school on previously vacant commercial land", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Prior Approval: Temporary use for commercial film-making", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Prior Approval: Demolition of building", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Demolition in a conservation area", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Listed building consent", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Consent to display an advertisement", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Hedgerow removal notice", Group = comingSoon },
            new SelectListItem{ Value = null, Text = "Tree works: Trees in conservation areas/subject to TPOs", Group = comingSoon },
        };
    }
}