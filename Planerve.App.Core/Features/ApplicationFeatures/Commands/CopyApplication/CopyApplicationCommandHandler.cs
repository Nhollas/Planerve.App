﻿using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Planerve.App.Core.Authorization.Requirements;
using Planerve.App.Core.Contracts.Specification.ApplicationSpecifications;
using Planerve.App.Core.Exceptions;
using Planerve.App.Core.Features.ApplicationFeatures.Commands.CreateApplication.DataHelpers;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.FormEntities;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.CopyApplication
{
    public class CopyApplicationCommandHandler : IRequestHandler<CopyApplicationCommand, Guid>
    {
        private readonly IUserService _userService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthorizationService _authorizationService;
        private readonly IMapper _mapper;
        private readonly string _userId;

        public CopyApplicationCommandHandler(
            IUserService userService,
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IAuthorizationService authorizationService)
        {
            _userService = userService;
            _unitOfWork = unitOfWork;
            _userId = _userService.UserId();
            _mapper = mapper;
            _authorizationService = authorizationService;
        }

        public async Task<Guid> Handle(CopyApplicationCommand request, CancellationToken cancellationToken)
        {
            var validator = new CopyApplicationCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            var user = await _userService.GetUser();

            var specification = new GetApplicationByIdSpecification(request.ApplicationId, _userId);

            var application = _unitOfWork.ApplicationRepository.FindWithSpecificationPattern(specification);

            var selectedApplication = application.First();

            var authorisedResult = await _authorizationService.AuthorizeAsync(user, selectedApplication.Users, ApplicationPolicies.CopyApplication);

            if (!authorisedResult.Succeeded)
            {
                throw new NotAuthorisedException(nameof(Application), _userId);
            }

            Guid newId = await CopyApplication(selectedApplication, request);
            await CopyForm(selectedApplication.Type.Value, request, newId);

            return newId;
        }

        private async Task<Guid> CopyApplication(Application application, CopyApplicationCommand command)
        {
            var applicationTypeInfo = ApplicationTypeHelper.GetTypeInfo(application.Type.Value, application.Type.CategoryValue);
            var applicationDocumentInfo = ApplicationDocumentHelper.GetDocumentInfo(application.Type.Value);

            Application applicationToCopy = new()
            {
                ApplicationReference = GenerateApplicationReference(),
                ApplicationName = command.ApplicationName,
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

            var copiedApplication = await _unitOfWork.ApplicationRepository.AddAsync(applicationToCopy);

            return copiedApplication.Id;
        }

        private static string GenerateApplicationReference()
        {
            var r = new Random();
            var x = r.Next(0, 10000000);
            var s = x.ToString("0000000");
            var appReference = $"PP-{s}";

            return appReference;
        }

        private async Task<Unit> CopyForm(int formType, CopyApplicationCommand command, Guid id)
        {
            switch (formType)
            {
                case 1:
                    var formA = await _unitOfWork.FormTypeARepository.GetByIdAsync(command.ApplicationId);

                    FormTypeA formTypeA = new()
                    {
                        FormId = id,
                        AgentSection = command.AgentDetails.Equals(true) ? formA.AgentSection : null,
                        ApplicantSection = command.ApplicantDetails.Equals(true) ? formA.ApplicantSection : null,
                        SiteSection = command.SiteDetails.Equals(true) ? formA.SiteSection : null,
                    };

                    await _unitOfWork.FormTypeARepository.AddAsync(formTypeA);
                    break;
                case 2:
                    var formB = await _unitOfWork.FormTypeBRepository.GetByIdAsync(command.ApplicationId);

                    FormTypeB formTypeB = new()
                    {
                        ApplicationId = id,
                        AgentSection = command.AgentDetails.Equals(true) ? formB.AgentSection : null,
                        ApplicantSection = command.ApplicantDetails.Equals(true) ? formB.ApplicantSection : null,
                        SiteSection = command.SiteDetails.Equals(true) ? formB.SiteSection : null,
                    };

                    await _unitOfWork.FormTypeBRepository.AddAsync(formTypeB);
                    break;
                case 3:
                    var formC = await _unitOfWork.FormTypeCRepository.GetByIdAsync(command.ApplicationId);

                    FormTypeC formTypeC = new()
                    {
                        ApplicationId = id,
                        AgentSection = command.AgentDetails.Equals(true) ? formC.AgentSection : null,
                        ApplicantSection = command.ApplicantDetails.Equals(true) ? formC.ApplicantSection : null,
                        SiteSection = command.SiteDetails.Equals(true) ? formC.SiteSection : null,
                    };

                    await _unitOfWork.FormTypeCRepository.AddAsync(formTypeC);
                    break;
                case 4:
                    var formD = await _unitOfWork.FormTypeDRepository.GetByIdAsync(command.ApplicationId);

                    FormTypeD formTypeD = new()
                    {
                        ApplicationId = id,
                        AgentSection = command.AgentDetails.Equals(true) ? formD.AgentSection : null,
                        ApplicantSection = command.ApplicantDetails.Equals(true) ? formD.ApplicantSection : null,
                        SiteSection = command.SiteDetails.Equals(true) ? formD.SiteSection : null,
                    };

                    await _unitOfWork.FormTypeDRepository.AddAsync(formTypeD);
                    break;
                case 5:
                    var formE = await _unitOfWork.FormTypeERepository.GetByIdAsync(command.ApplicationId);

                    FormTypeE formTypeE = new()
                    {
                        ApplicationId = id,
                        AgentSection = command.AgentDetails.Equals(true) ? formE.AgentSection : null,
                        ApplicantSection = command.ApplicantDetails.Equals(true) ? formE.ApplicantSection : null,
                        SiteSection = command.SiteDetails.Equals(true) ? formE.SiteSection : null,
                    };

                    await _unitOfWork.FormTypeERepository.AddAsync(formTypeE);
                    break;
            }
            return Unit.Value;
        }
    }
}