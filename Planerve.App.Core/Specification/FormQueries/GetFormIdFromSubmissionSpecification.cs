using Planerve.App.Core.Classes;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System;

namespace Planerve.App.Core.Specification.FormQueries
{
    public class GetFormIdFromSubmissionSpecification : BaseSpecification<Submission>
    {
        public GetFormIdFromSubmissionSpecification(Guid formId) : base(x => x.FormId == formId)
        {

        }
    }
}
