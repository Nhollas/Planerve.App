using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class ApplicantSection
    {
        [Required]
        public string Name { get; set; } = "Applicant";
    }
}
