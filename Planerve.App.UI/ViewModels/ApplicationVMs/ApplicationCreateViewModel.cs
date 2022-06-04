using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Planerve.App.UI.ViewModels.ApplicationVMs
{
    public class ApplicationCreateViewModel
    {
        [Display(Name = "Application Name")]
        public string ApplicationName { get; set; }
        public int ApplicationType { get; set; }
        [Display(Name = "Select Address")]
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string AddressLineThree { get; set; }
        [Display(Name = "Site Postcode")]
        public string Postcode { get; set; }
        public List<SelectListItem> ApplicationTypes { get; set; }

        public void OnGet()
        {
            var householder = new SelectListGroup { Name = "Householder Planning & Prior Approval" };
            var full = new SelectListGroup { Name = "Full Planning" };
            var outline = new SelectListGroup { Name = "Outline Planning" };
            var existing = new SelectListGroup { Name = "Existing Consents" };
            var lawfulDevelopment = new SelectListGroup { Name = "Lawful Development Certificate" };
            var other = new SelectListGroup { Name = "Other Consents" };

            ApplicationTypes = new List<SelectListItem>
            {
                new SelectListItem{ Value = "1", Text = "Householder planning permission", Group = householder },
                new SelectListItem{ Value = "2", Text = "Householder planning & demolition in a conservation area", Group = householder },
                new SelectListItem{ Value = "3", Text = "Householder planning & listed building consent", Group = householder },
                new SelectListItem{ Value = "4", Text = "Prior Approval: Larger home extension", Group = householder },
                new SelectListItem{ Value = "5", Text = "Prior Approval: Additional storeys on a dwellinghouse", Group = householder },
                new SelectListItem{ Value = "6", Text = "Full planning permission", Group = full },
                new SelectListItem{ Value = "7", Text = "Full planning & demolition in a conservation area", Group = full },
                new SelectListItem{ Value = "8", Text = "Full planning & listed building consent", Group = full },
                new SelectListItem{ Value = "9", Text = "Full planning & display of advertisements", Group = full },
                new SelectListItem{ Value = "10", Text = "Outline planning permission: Some matters reserved", Group = outline },
                new SelectListItem{ Value = "11", Text = "Outline planning permission: All matters reserved", Group = outline },
                new SelectListItem{ Value = "12", Text = "Approval of reserved matters", Group = existing },
                new SelectListItem{ Value = "13", Text = "Approval of details reserved by a condition", Group = existing },
                new SelectListItem{ Value = "14", Text = "Non-Material Amendment", Group = existing },
                new SelectListItem{ Value = "15", Text = "Removal/Variation of a condition", Group = existing },
                new SelectListItem{ Value = "16", Text = "Lawful development: Existing use", Group = lawfulDevelopment },
                new SelectListItem{ Value = "17", Text = "Lawful development: Proposed use", Group = lawfulDevelopment },
                new SelectListItem{ Value = "18", Text = "Listed building consent", Group = other },
                new SelectListItem{ Value = "19", Text = "Consent to display an advertisement", Group = other },
                new SelectListItem{ Value = "20", Text = "Tree works: Trees in conservation areas/subject to TPOs", Group = other },
            };
        }
    }
}
