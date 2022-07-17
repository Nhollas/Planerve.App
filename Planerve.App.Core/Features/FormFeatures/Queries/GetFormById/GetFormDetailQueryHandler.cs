using MediatR;
using Planerve.App.Core.Exceptions;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Specification.FormQueries;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.FormFeatures.Queries.GetFormById
{
    public class GetFormDetailQueryHandler : IRequestHandler<GetFormDetailQuery, FormDetailVM>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAsyncRepository<Submission> _repository;

        public GetFormDetailQueryHandler(
            IUnitOfWork unitOfWork,
            IAsyncRepository<Submission> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public Task<FormDetailVM> Handle(GetFormDetailQuery request, CancellationToken cancellationToken)
        {
            GetFormIdFromSubmissionSpecification specification = new(request.FormId);

            Submission submission = _repository.FindWithSpecificationPattern(specification).FirstOrDefault();

            if (submission == null)
            {
                throw new NotFoundException("Form", request.FormId);
            }

            object form = GetForm(submission);

            var result = new FormDetailVM { Data = form, Type = submission.FormType };

            // As the client will need to know how to deserialize the data, we pass the forms type in as well so it can be handled on the frontend.
            return Task.FromResult(result);
        }


        // As object is a base entity it can be anything, while I don't like to uses switches it forms an easy implementation.
        private object GetForm(Submission submission)
        {
            switch (submission.FormType)
            {
                case 1:
                    GetFormTypeASpecification specificationA = new(submission.FormId);
                    return _unitOfWork.FormTypeARepository.FindWithSpecificationPattern(specificationA).FirstOrDefault();
                case 2:
                    GetFormTypeBSpecification specificationB = new(submission.FormId);
                    return _unitOfWork.FormTypeBRepository.FindWithSpecificationPattern(specificationB).FirstOrDefault();
                case 3:
                    GetFormTypeCSpecification specificationC = new(submission.FormId);
                    return _unitOfWork.FormTypeCRepository.FindWithSpecificationPattern(specificationC).FirstOrDefault();
                case 4:
                    GetFormTypeDSpecification specificationD = new(submission.FormId);
                    return _unitOfWork.FormTypeDRepository.FindWithSpecificationPattern(specificationD).FirstOrDefault();
                case 5:
                    GetFormTypeESpecification specificationE = new(submission.FormId);
                    return _unitOfWork.FormTypeERepository.FindWithSpecificationPattern(specificationE).FirstOrDefault();
                default:
                    return null;
            }
        }
    }
}
