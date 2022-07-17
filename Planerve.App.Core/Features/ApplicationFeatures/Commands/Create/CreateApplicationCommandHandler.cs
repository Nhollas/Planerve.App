using AutoMapper;
using MediatR;
using Planerve.App.Core.Exceptions;
using Planerve.App.Core.Features.ApplicationFeatures.Commands.Create.DataHelpers;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.FormEntities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.Create
{
    public class CreateApplicationCommandHandler : IRequestHandler<CreateApplicationCommand, Guid>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateApplicationCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateApplicationCommand request, CancellationToken cancellationToken)
        {
            // Validate command.
            var validator = new CreateApplicationCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            Application createdApplication = await CreateApplication(request);
            await CreateForm(createdApplication.Submission.FormId, request.ApplicationType);

            return createdApplication.AppId;
        }

        /*
            Based on the request command, static data will be pulled from the DataHelpers dictionary classes.
            That data is mapped over via AutoMapper.
        */
        private async Task<Application> CreateApplication(CreateApplicationCommand request)
        {
            SubmissionHelper.Submission submissionInfo = SubmissionHelper.GetSubmissionInfo(request.ApplicationType, request.ApplicationCategory);

            Application applicationToCreate = new()
            {
                AppName = request.ApplicationName,
                AppReference = GenerateApplicationReference(),
                AppVersion = "V1",
                AppStatus = "Draft",
                AppType = request.ApplicationType,
                AppCategory = request.ApplicationCategory,
                PercentageComplete = 7,
                Submission = _mapper.Map<Submission>(submissionInfo)
            };

            Application createdApplication = await _unitOfWork.ApplicationRepository.AddAsync(applicationToCreate);

            return createdApplication;
        }

        // Based on the request command applicationType, we creating the respective form and it's unique Id is the same as the application.
        private async Task CreateForm(Guid formId, int formType)
        {
            switch (formType)
            {
                case 1:
                    FormTypeA formTypeA = new();
                    formTypeA.Initialize(formId);

                    await _unitOfWork.FormTypeARepository.AddAsync(formTypeA);
                    break;
                case 2:
                    FormTypeB formTypeB = new();
                    formTypeB.Initialize(formId);

                    await _unitOfWork.FormTypeBRepository.AddAsync(formTypeB);
                    break;
                case 3:
                    FormTypeC formTypeC = new();
                    formTypeC.Initialize(formId);

                    await _unitOfWork.FormTypeCRepository.AddAsync(formTypeC);
                    break;
                case 4:
                    FormTypeD formTypeD = new();
                    formTypeD.Initialize(formId);

                    await _unitOfWork.FormTypeDRepository.AddAsync(formTypeD);
                    break;
                case 5:
                    FormTypeE formTypeE = new();
                    formTypeE.Initialize(formId);

                    await _unitOfWork.FormTypeERepository.AddAsync(formTypeE);
                    break;
            }
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