using AutoMapper;
using MediatR;
using Planerve.App.Core.Contracts.Identity;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Exceptions;
using Planerve.App.Core.Features.ApplicationFeatures.Commands.CreateApplication.DataHelpers;
using Planerve.App.Core.Features.ApplicationFeatures.Dtos;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.FormEntities;
using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.CreateApplication
{
    public class CreateApplicationCommandHandler : IRequestHandler<CreateApplicationCommand, Guid>
    {
        private readonly IAsyncRepository<Application> _repository;
        private readonly IFormRepositoryWrapper _formRepositoryWrapper;
        private readonly IPostcodeService _postcodeService;
        private readonly IMapper _mapper;
        private readonly ILoggedInUserService _loggedInUserService;


        public CreateApplicationCommandHandler(IMapper mapper, IAsyncRepository<Application> repository, ILoggedInUserService loggedInUserService, IPostcodeService postcodeService, IFormRepositoryWrapper formRepositoryWrapper)
        {
            _mapper = mapper;
            _repository = repository;;
            _loggedInUserService = loggedInUserService;
            _postcodeService = postcodeService;
            _formRepositoryWrapper = formRepositoryWrapper;
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
            // Grab userId from API user service.
            var userId = _loggedInUserService.UserId().Result;

            // Grab application address from API address service
            var addressData = await _postcodeService.ValidatePostcode(request.Postcode);

            if (addressData is null)
            {
                throw new NotFoundException(nameof(PostcodeDataDto), $"The postcode {request.Postcode} is not valid.");
            }

            var postcodeData = JsonSerializer.Deserialize<PostcodeDataDto>(addressData,
            new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            ApplicationTypeHelper applicationTypeHelper = new();
            ApplicationDocumentHelper applicationDocumentHelper = new();
            ApplicationFormHelper applicationFormHelper = new();

            var applicationTypeInfo = applicationTypeHelper.GetTypeInfo(request.ApplicationType, request.ApplicationCategory);
            var applicationDocumentInfo = applicationDocumentHelper.GetDocumentInfo(request.ApplicationType);
            var applicationFormInfo = applicationFormHelper.GetFormInfo(request.ApplicationType);

            // Create mock application.
            Application applicationToCreate = new()
            {
                ApplicationReference = await GenerateApplicationReference(),
                ApplicationName = request.ApplicationName,
                OwnerId = userId,
                VersionNumber = "V1",
                CreatedDate = DateTime.UtcNow,
                Data = new ApplicationData()
                {
                    Type = _mapper.Map<ApplicationType>(applicationTypeInfo),
                    Address = _mapper.Map<ApplicationAddress>(postcodeData.result),
                    Document = _mapper.Map<ApplicationDocument>(applicationDocumentInfo),
                    Progress = new ApplicationProgress()
                    {
                        ApplicationStatus = "DRAFT"
                    }
                }
            };

            var createdApplication = await _repository.AddAsync(applicationToCreate);

            return createdApplication.Id;
        }

        private async Task CreateForm(Guid applicationId, int formType)
        {
            switch (formType)
            {
                case 1:
                    FormTypeA formTypeA = new()
                    {
                        FormId = Guid.NewGuid(),
                        ApplicationId = applicationId,
                        CreatedDate = DateTime.UtcNow,
                        OwnerId = _loggedInUserService.UserId().Result
                    };

                    await _formRepositoryWrapper.FormTypeA.AddAsync(formTypeA);
                    break;
                case 2:
                    FormTypeB formTypeB = new()
                    {
                        FormId = Guid.NewGuid(),
                        ApplicationId = applicationId,
                        CreatedDate = DateTime.UtcNow,
                        OwnerId = _loggedInUserService.UserId().Result
                    };

                    await _formRepositoryWrapper.FormTypeB.AddAsync(formTypeB);
                    break;
                case 3:
                    FormTypeC formTypeC = new()
                    {
                        FormId = Guid.NewGuid(),
                        ApplicationId = applicationId,
                        CreatedDate = DateTime.UtcNow,
                        OwnerId = _loggedInUserService.UserId().Result
                    };

                    await _formRepositoryWrapper.FormTypeC.AddAsync(formTypeC);
                    break;
                case 4:
                    FormTypeD formTypeD = new()
                    {
                        FormId = Guid.NewGuid(),
                        ApplicationId = applicationId,
                        CreatedDate = DateTime.UtcNow,
                        OwnerId = _loggedInUserService.UserId().Result
                    };

                    await _formRepositoryWrapper.FormTypeD.AddAsync(formTypeD);
                    break;
                case 5:
                    FormTypeE formTypeE = new()
                    {
                        FormId = Guid.NewGuid(),
                        ApplicationId = applicationId,
                        CreatedDate = DateTime.UtcNow,
                        OwnerId = _loggedInUserService.UserId().Result
                    };

                    await _formRepositoryWrapper.FormTypeE.AddAsync(formTypeE);
                    break;
                case 6:
                    FormTypeF formTypeF = new()
                    {
                        FormId = Guid.NewGuid(),
                        ApplicationId = applicationId,
                        CreatedDate = DateTime.UtcNow,
                        OwnerId = _loggedInUserService.UserId().Result
                    };

                    await _formRepositoryWrapper.FormTypeF.AddAsync(formTypeF);
                    break;
                case 7:
                    FormTypeG formTypeG = new()
                    {
                        FormId = Guid.NewGuid(),
                        ApplicationId = applicationId,
                        CreatedDate = DateTime.UtcNow,
                        OwnerId = _loggedInUserService.UserId().Result
                    };

                    await _formRepositoryWrapper.FormTypeG.AddAsync(formTypeG);
                    break;
                case 8:
                    FormTypeH formTypeH = new()
                    {
                        FormId = Guid.NewGuid(),
                        ApplicationId = applicationId,
                        CreatedDate = DateTime.UtcNow,
                        OwnerId = _loggedInUserService.UserId().Result
                    };

                    await _formRepositoryWrapper.FormTypeH.AddAsync(formTypeH);
                    break;
                case 9:
                    FormTypeI formTypeI = new()
                    {
                        FormId = Guid.NewGuid(),
                        ApplicationId = applicationId,
                        CreatedDate = DateTime.UtcNow,
                        OwnerId = _loggedInUserService.UserId().Result
                    };

                    await _formRepositoryWrapper.FormTypeI.AddAsync(formTypeI);
                    break;
                case 10:
                    FormTypeJ formTypeJ = new()
                    {
                        FormId = Guid.NewGuid(),
                        ApplicationId = applicationId,
                        CreatedDate = DateTime.UtcNow,
                        OwnerId = _loggedInUserService.UserId().Result
                    };

                    await _formRepositoryWrapper.FormTypeJ.AddAsync(formTypeJ);
                    break;
                case 11:
                    FormTypeK formTypeK = new()
                    {
                        FormId = Guid.NewGuid(),
                        ApplicationId = applicationId,
                        CreatedDate = DateTime.UtcNow,
                        OwnerId = _loggedInUserService.UserId().Result
                    };

                    await _formRepositoryWrapper.FormTypeK.AddAsync(formTypeK);
                    break;
                case 12:
                    FormTypeL formTypeL = new()
                    {
                        FormId = Guid.NewGuid(),
                        ApplicationId = applicationId,
                        CreatedDate = DateTime.UtcNow,
                        OwnerId = _loggedInUserService.UserId().Result
                    };

                    await _formRepositoryWrapper.FormTypeL.AddAsync(formTypeL);
                    break;
                case 13:
                    FormTypeM formTypeM = new()
                    {
                        FormId = Guid.NewGuid(),
                        ApplicationId = applicationId,
                        CreatedDate = DateTime.UtcNow,
                        OwnerId = _loggedInUserService.UserId().Result
                    };

                    await _formRepositoryWrapper.FormTypeM.AddAsync(formTypeM);
                    break;
                case 14:
                    FormTypeN formTypeN = new()
                    {
                        FormId = Guid.NewGuid(),
                        ApplicationId = applicationId,
                        CreatedDate = DateTime.UtcNow,
                        OwnerId = _loggedInUserService.UserId().Result
                    };

                    await _formRepositoryWrapper.FormTypeN.AddAsync(formTypeN);
                    break;
                case 15:
                    FormTypeO formTypeO = new()
                    {
                        FormId = Guid.NewGuid(),
                        ApplicationId = applicationId,
                        CreatedDate = DateTime.UtcNow,
                        OwnerId = _loggedInUserService.UserId().Result
                    };

                    await _formRepositoryWrapper.FormTypeO.AddAsync(formTypeO);
                    break;
                case 16:
                    FormTypeP formTypeP = new()
                    {
                        FormId = Guid.NewGuid(),
                        ApplicationId = applicationId,
                        CreatedDate = DateTime.UtcNow,
                        OwnerId = _loggedInUserService.UserId().Result
                    };

                    await _formRepositoryWrapper.FormTypeP.AddAsync(formTypeP);
                    break;
                case 17:
                    FormTypeQ formTypeQ = new()
                    {
                        FormId = Guid.NewGuid(),
                        ApplicationId = applicationId,
                        CreatedDate = DateTime.UtcNow,
                        OwnerId = _loggedInUserService.UserId().Result
                    };

                    await _formRepositoryWrapper.FormTypeQ.AddAsync(formTypeQ);
                    break;
                case 18:
                    FormTypeR formTypeR = new()
                    {
                        FormId = Guid.NewGuid(),
                        ApplicationId = applicationId,
                        CreatedDate = DateTime.UtcNow,
                        OwnerId = _loggedInUserService.UserId().Result
                    };

                    await _formRepositoryWrapper.FormTypeR.AddAsync(formTypeR);
                    break;
                case 19:
                    FormTypeS formTypeS = new()
                    {
                        FormId = Guid.NewGuid(),
                        ApplicationId = applicationId,
                        CreatedDate = DateTime.UtcNow,
                        OwnerId = _loggedInUserService.UserId().Result
                    };

                    await _formRepositoryWrapper.FormTypeS.AddAsync(formTypeS);
                    break;
                case 20:
                    FormTypeT formTypeT = new()
                    {
                        FormId = Guid.NewGuid(),
                        ApplicationId = applicationId,
                        CreatedDate = DateTime.UtcNow,
                        OwnerId = _loggedInUserService.UserId().Result
                    };

                    await _formRepositoryWrapper.FormTypeT.AddAsync(formTypeT);
                    break;
            }
        }

        static Task<string> GenerateApplicationReference()
        {
            var r = new Random();
            var x = r.Next(0, 10000000);
            var s = x.ToString("0000000");
            var appReference = $"PP-{s}";

            return Task.FromResult(appReference);
        }
    }
}