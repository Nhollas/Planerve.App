using AutoMapper;
using MediatR;
using Planerve.App.Core.Exceptions;
using Planerve.App.Core.Features.ApplicationFeatures.Commands.Create.DataHelpers;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Core.Specification.ApplicationQueries;
using Planerve.App.Core.Specification.FormQueries;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.FormEntities;
using Planerve.App.Domain.Entities.FormEntities.Shared;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.Copy
{
    public class CopyApplicationCommandHandler : IRequestHandler<CopyApplicationCommand, Guid>
    {
        private readonly IUserService _userService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly string _userId;

        public CopyApplicationCommandHandler(
            IUserService userService,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _userService = userService;
            _unitOfWork = unitOfWork;
            _userId = _userService.UserId();
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CopyApplicationCommand request, CancellationToken cancellationToken)
        {
            // Validate command.
            var validator = new CopyApplicationCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            var specification = new GetApplicationByIdSpecification(request.ApplicationId, _userId);

            var application = _unitOfWork.ApplicationRepository.FindWithSpecificationPattern(specification).FirstOrDefault();

            if (application == null)
            {
                throw new NotFoundException(nameof(Application), request.ApplicationId);
            }

            Application copiedApplication = await CopyApplication(application, request);
            await CopyForm(application, copiedApplication, request);

            return copiedApplication.AppId;
        }

        // Copy application data that was passed in the parameter.
        private async Task<Application> CopyApplication(Application application, CopyApplicationCommand command)
        {
            SubmissionHelper.Submission submissionInfo = SubmissionHelper.GetSubmissionInfo(application.AppType, application.AppCategory);

            Application applicationToCopy = new()
            {
                AppName = command.ApplicationName,
                AppReference = GenerateApplicationReference(),
                AppVersion = "V1",
                AppStatus = "Draft",
                AppType = application.AppType,
                AppCategory = application.AppCategory,
                PercentageComplete = 7,
                Submission = _mapper.Map<Submission>(submissionInfo)
            };

            Application copiedApplication = await _unitOfWork.ApplicationRepository.AddAsync(applicationToCopy);

            return copiedApplication;
        }

        /*
            Based on what the user wants to copy over from the existing form will determine what gets pulled over.
            As each form has it's own DbTable we will need to use UnitOfWork to call each repository based on it's type.
        */
        private async Task<Unit> CopyForm(Application existingApplication, Application copiedApplication, CopyApplicationCommand command)
        {
            Guid newFormId = copiedApplication.Submission.FormId;

            switch (copiedApplication.AppType)
            {
                case 1:
                    // Get existing form data.
                    GetFormTypeASpecification specificationA = new(existingApplication.Submission.FormId);
                    FormTypeA existingFormTypeA = _unitOfWork.FormTypeARepository.FindWithSpecificationPattern(specificationA).FirstOrDefault();

                    FormTypeA formTypeA = new();
                    formTypeA.Initialize(newFormId);

                    // Based on the commands booleans, copy the existing data from the agent, applicant and site sections.
                    formTypeA.AgentSection = command.AgentDetails.Equals(true) ? _mapper.Map<AgentSection>(existingFormTypeA.AgentSection) : new AgentSection() { Id = newFormId };
                    formTypeA.ApplicantSection = command.ApplicantDetails.Equals(true) ? _mapper.Map<ApplicantSection>(existingFormTypeA.ApplicantSection) : new ApplicantSection() { Id = newFormId };
                    formTypeA.SiteSection = command.SiteDetails.Equals(true) ? _mapper.Map<SiteSection>(existingFormTypeA.SiteSection) : new SiteSection() { Id = newFormId };

                    await _unitOfWork.FormTypeARepository.AddAsync(formTypeA);
                    break;
            }
            return Unit.Value;
        }

        // TODO: While it's very unlikely, should perform a check to make sure this ref doesn't already exist.
        private static string GenerateApplicationReference()
        {
            var r = new Random();
            var x = r.Next(0, 1000000000);
            var s = x.ToString("000000000");
            var appReference = $"PP-{s}";

            return appReference;
        }
    }
}
