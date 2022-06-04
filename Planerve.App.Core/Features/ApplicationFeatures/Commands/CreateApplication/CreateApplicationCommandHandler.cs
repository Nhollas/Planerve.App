using AutoMapper;
using MediatR;
using Planerve.App.Core.Contracts.Identity;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Exceptions;
using Planerve.App.Core.Features.ApplicationFeatures.Commands.CreateApplication.DataHelpers;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.CreateApplication
{
    public class CreateApplicationCommandHandler : IRequestHandler<CreateApplicationCommand, Guid>
    {
        private readonly IAsyncRepository<Application> _repository;
        private readonly IPostcodeService _postcodeService;
        private readonly IMapper _mapper;
        private readonly ILoggedInUserService _loggedInUserService;


        public CreateApplicationCommandHandler(IMapper mapper, IAsyncRepository<Application> repository, ILoggedInUserService loggedInUserService, IPostcodeService postcodeService)
        {
            _mapper = mapper;
            _repository = repository;
            _loggedInUserService = loggedInUserService;
            _postcodeService = postcodeService;
        }

        public async Task<Guid> Handle(CreateApplicationCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateApplicationCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            var modifiedRequest = await GenerateDefaultData(request);

            var application = await _repository.AddAsync(modifiedRequest);

            return application.Id;
        }

        private async Task<Application> GenerateDefaultData(CreateApplicationCommand request)
        {
            // Grab userId from API user service.
            var userId = _loggedInUserService.UserId().Result;

            // Grab application address from API address service
            var postCodeData = await _postcodeService.ValidatePostcode(request.Postcode);

            if (postCodeData is null)
            {
                throw new NotFoundException(nameof(PostcodeDataDto), $"The postcode {request.Postcode} is not valid.");
            }

            var postcodeData = JsonSerializer.Deserialize<PostcodeDataDto>(postCodeData,
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
                ApplicationReference = await GenerateAppReference(),
                ApplicationName = request.ApplicationName,
                OwnerId = userId,
                VersionNumber = "V1",
                CreatedDate = DateTime.UtcNow,
                Data = new ApplicationData()
                {
                    Type = _mapper.Map<ApplicationType>(applicationTypeInfo),
                    Address = _mapper.Map<ApplicationAddress>(postcodeData.result),
                    Form = _mapper.Map<ApplicationForm>(applicationFormInfo),
                    Document = _mapper.Map<ApplicationDocument>(applicationDocumentInfo),
                    Progress = new ApplicationProgress()
                    {
                        ApplicationStatus = "DRAFT"
                    }
                }
            };
            return applicationToCreate;
        }

        private static Task<string> GenerateAppReference()
        {
            var r = new Random();
            var x = r.Next(0, 10000000);
            var s = x.ToString("0000000");
            var appReference = $"PP-{s}";

            return Task.FromResult(appReference);
        }
    }
}