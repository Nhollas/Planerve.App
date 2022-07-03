using AutoMapper;
using MediatR;
using Planerve.App.Core.Exceptions;
using Planerve.App.Core.Features.ApplicationFeatures.Commands.CreateApplication.DataHelpers;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.FormEntities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.CreateApplication
{
    public class CreateApplicationCommandHandler : IRequestHandler<CreateApplicationCommand, Guid>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly string _userId;

        public CreateApplicationCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IUserService userService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userService = userService;
            _userId = _userService.UserId();
        }

        public async Task<Guid> Handle(CreateApplicationCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateApplicationCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            Guid applicationId = await CreateApplication(request);
            await CreateForm(applicationId, request.ApplicationType);

            return applicationId;
        }

        private async Task<Guid> CreateApplication(CreateApplicationCommand request)
        {
            var applicationTypeInfo = ApplicationTypeHelper.GetTypeInfo(request.ApplicationType, request.ApplicationCategory);
            var applicationDocumentInfo = ApplicationDocumentHelper.GetDocumentInfo(request.ApplicationType);

            Application applicationToCreate = new()
            {
                ApplicationName = request.ApplicationName,
                ApplicationReference = GenerateApplicationReference(),
                VersionNumber = "V1",
                Type = _mapper.Map<ApplicationType>(applicationTypeInfo),
                Document = _mapper.Map<ApplicationDocument>(applicationDocumentInfo),
                Progress = new ApplicationProgress()
                {
                    ApplicationStatus = "DRAFT",
                    ProgressPercentage = 10
                },
                Users = new PermissionUser()
                {
                    OwnerId = _userId,
                }
            };

            Application createdApplication = await _unitOfWork.ApplicationRepository.AddAsync(applicationToCreate);

            return createdApplication.Id;
        }

        private async Task CreateForm(Guid applicationId, int formType)
        {
            switch (formType)
            {
                case 1:
                    FormTypeA formTypeA = new()
                    {
                        FormId = applicationId,
                    };

                    await _unitOfWork.FormTypeARepository.AddAsync(formTypeA);
                    break;
                case 2:
                    FormTypeB formTypeB = new()
                    {
                        ApplicationId = applicationId,
                    };

                    await _unitOfWork.FormTypeBRepository.AddAsync(formTypeB);
                    break;
                case 3:
                    FormTypeC formTypeC = new()
                    {
                        ApplicationId = applicationId,
                    };

                    await _unitOfWork.FormTypeCRepository.AddAsync(formTypeC);
                    break;
                case 4:
                    FormTypeD formTypeD = new()
                    {
                        ApplicationId = applicationId,
                    };

                    await _unitOfWork.FormTypeDRepository.AddAsync(formTypeD);
                    break;
                case 5:
                    FormTypeE formTypeE = new()
                    {
                        ApplicationId = applicationId,
                    };

                    await _unitOfWork.FormTypeERepository.AddAsync(formTypeE);
                    break;
            }
        }

        private static string GenerateApplicationReference()
        {
            var r = new Random();
            var x = r.Next(0, 10000000);
            var s = x.ToString("0000000");
            var appReference = $"PP-{s}";

            return appReference;
        }
    }
}