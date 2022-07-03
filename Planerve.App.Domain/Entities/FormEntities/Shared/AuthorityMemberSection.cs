using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    [Owned]
    public class AuthorityMemberSection
    {
        public Guid Id { get; set; }
        public bool IsRelated { get; set; }
        public string RelatedInformation { get; set; }
    }
}
