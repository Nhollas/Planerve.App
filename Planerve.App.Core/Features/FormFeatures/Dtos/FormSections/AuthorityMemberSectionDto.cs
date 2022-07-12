using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Core.Features.FormFeatures.Dtos.FormSections
{
    public class AuthorityMemberSectionDto
    {
        public bool IsRelated { get; set; }
        public string RelatedInformation { get; set; }
    }
}
